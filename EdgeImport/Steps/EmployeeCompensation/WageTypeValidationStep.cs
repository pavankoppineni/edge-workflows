using EdgeImport.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Workflows.Compensation
{
    public partial class EmployeeCompensationWorkflow
    {
        public Task ValidateWageTypeAsync(IMessage message, CancellationToken cancellationToken)
        {
            Console.WriteLine("Validating wage type");
            return Task.CompletedTask;
        }
    }
}
