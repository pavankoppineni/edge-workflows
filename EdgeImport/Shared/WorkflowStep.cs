using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Shared
{
    public delegate Task WorkflowStepAction(IMessage message, CancellationToken cancellationToken);

    public class WorkflowStep
    {
        public WorkflowStep(string name, WorkflowStepAction action)
        {
            Name = name;
            Action = action;
        }

        public string Name { get; private set; }
        public WorkflowStepAction Action { get; private set; }
    }
}
