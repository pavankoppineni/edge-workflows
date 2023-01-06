using EdgeImport.Shared;
using EdgeImport.Workers;
using EdgeImport.Workflows;
using EdgeImport.Workflows.Compensation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EdgeImport
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<EdgeImportWorker<IndividualTargetsWorkflow>>();
                services.AddHostedService<EdgeImportWorker<SalaryStructureWorkflow>>();
                services.AddHostedService<EdgeImportWorker<EmployeeCompensationWorkflow>>();
            });


        //var livePortalsFile = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\kafka_learning\Concert\src\EdgeImport\Portals\live.txt");
        //var inprogressPortalsFile = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\kafka_learning\Concert\src\EdgeImport\Portals\inprogress.txt");
        //var pendingPortals = new List<string>();
        //var livePortals = new HashSet<string>();
        //foreach (var live in livePortalsFile)
        //{
        //    livePortals.Add(live.ToUpper());
        //}
        //foreach(var pending in inprogressPortalsFile)
        //{
        //    if(livePortals.Contains(pending.ToUpper()))
        //    {
        //        pendingPortals.Add(pending.ToUpper());
        //    }
        //}
        //var list = "";
        //foreach(var pending in pendingPortals)
        //{
        //    list += pending.ToUpper() + "\n";
        //}
        //CreateHostBuilder(args).Build().Run();
    }
}
