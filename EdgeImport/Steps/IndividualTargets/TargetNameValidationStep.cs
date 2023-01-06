using EdgeImport.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Workflows.Compensation
{
    public partial class IndividualTargetsWorkflow
    {
        private Task ValidateTargetNameAsync(IMessage message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
