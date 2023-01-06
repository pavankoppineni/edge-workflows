using EdgeImport.Shared;
using EdgeImport.Workflows;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Workers
{
    public class EdgeImportWorker<TWorkflow> : BackgroundService where TWorkflow : IWorkflow, new()
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var workFlow = new TWorkflow();
            while (!stoppingToken.IsCancellationRequested)
            {
                var message = new Message { };
                await workFlow.ExecuteAsync(message, stoppingToken);
            }
        }
    }
}
