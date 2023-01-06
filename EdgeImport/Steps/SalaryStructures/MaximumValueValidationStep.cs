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
        private Task ValidateMaximumValueAsync(IMessage message, CancellationToken cancellationToken)
        {
            Console.WriteLine("Validating maximum value");
            return Task.CompletedTask;
        }
    }
}
