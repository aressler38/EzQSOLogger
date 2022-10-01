using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Azure.Storage.Blobs;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((services) =>
    {
        var bsc = new BlobServiceClient(Environment.GetEnvironmentVariable("AzureWebJobsStorage"));
        services.AddSingleton(bsc);
    })
    .Build();

host.Run();