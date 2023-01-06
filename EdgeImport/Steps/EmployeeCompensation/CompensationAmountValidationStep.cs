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
        private Task ValidateCompensationAmountAsync(IMessage message, CancellationToken cancellationToken)
        {
            Console.WriteLine("Validating compensation amount");
            return Task.CompletedTask;
        }
    }
}
