using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace DurableChained;

public class WriteBlob
{
    [FunctionName("mlmdurablChainedfunc")]
    [StorageAccount("DefaultEndpointsProtocol=https;AccountName=mlmdurablchainedstr;AccountKey=zddBBmtHQfWeGZZ6stm71O6YozG+LTQ3H8Cx//dSmNAFcqJ3mt7ZSWr1nnpytw9S4rW+F2di9lfZ+ASt4CfPKA==;EndpointSuffix=core.windows.net
")]
    public async Task<string> Run(
        [ActivityTrigger] AppStatus status,
        Binder binder,
        ILogger log)
    {
        log.LogInformation($"WriteBlob received status for: {status.Component} with timestamp: {status.TimestampUtc}");

        var blobName = $"heartbeat/{DateTime.UtcNow.ToString("yyyyMMddHHmmss")}";
        using (var writer = await binder.BindAsync<TextWriter>(new BlobAttribute(blobName)))
        {
            writer.Write(JsonSerializer.Serialize(status));
        }

        log.LogInformation($"Created blob: {blobName}");
        return blobName;
    }
}
