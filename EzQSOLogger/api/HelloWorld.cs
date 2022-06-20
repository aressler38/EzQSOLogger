using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Delara.EzQSOLogger
{
    public class HelloWorld
    {
        private readonly ILogger _logger;

        public HelloWorld(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HelloWorld>();
        }

#if DEBUG
        [Function("debug1")]
        public HttpResponseData Debug1([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "debug/debug1")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
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
}
