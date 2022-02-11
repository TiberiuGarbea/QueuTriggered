using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace QueuTriggeredFA
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("test", Connection = "connectionSA")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function started sleeping before processing: {myQueueItem}");
            Thread.Sleep(300000);

            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
