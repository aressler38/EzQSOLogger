using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Azure.Storage.Blobs;

namespace EzQSOLogger;

public class HelloWorld
{
    private readonly ILogger _logger;
    private readonly BlobServiceClient _blobServiceClient;

    public HelloWorld(BlobServiceClient blobServiceClient, ILogger<HelloWorld> logger)
    {
        _blobServiceClient = blobServiceClient;
        _logger = logger;
    }

#if DEBUG
    [Function("debug1")]
    public async Task<HttpResponseData> Debug1([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "debug/debug1")] HttpRequestData req)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);
        var bcc = _blobServiceClient.GetBlobContainerClient("qso-logs");
        var bc = bcc.GetBlobClient("myblob");
        try
        {
            await bc.UploadAsync(new BinaryData(System.Text.Encoding.UTF8.GetBytes("Hello World")), overwrite: true);
        }
        catch (Azure.RequestFailedException exc) when (exc.Status == 404 && exc.ErrorCode == "ContainerNotFound")
        {
            await _blobServiceClient.CreateBlobContainerAsync("qso-logs");
            await bc.UploadAsync(new BinaryData(System.Text.Encoding.UTF8.GetBytes("Hello World")), overwrite: true);
        }

        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        response.WriteString("Welcome to Azure Functions!");
        return response;
    }
#endif


    [Function("HelloWorld")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

        response.WriteString("Welcome to Azure Functions!");

        return response;
    }
}

