using EdgeImport.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Workflows.Compensation
{
    public partial class SalaryStructureWorkflow
    {
        private Task ValidateMidValueAsync(IMessage message, CancellationToken cancellationToken)
        {
            Console.WriteLine("Validating mid value");
            return Task.CompletedTask;
        }
    }
}
