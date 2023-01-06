using EdgeImport.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdgeImport.Workflows
{
    /// <inheritdoc />
    public abstract class Workflow : IWorkflow
    {
        private readonly LinkedList<WorkflowStep> _workflowSteps;
        protected Workflow()
        {
            _workflowSteps = new LinkedList<WorkflowStep>();
        }

        /// <summary>
        /// Adds workflow step
        /// </summary>
        /// <param name="workflowStep"></param>
        protected void AddStep(string stepName, WorkflowStepAction action)
        {
            var workflowStep = new WorkflowStep(stepName, action);
            _workflowSteps.AddLast(workflowStep);
        }

        /// <inheritdoc />
        public async Task ExecuteAsync(IMessage message, CancellationToken cancellationToken)
        {
            var currentStep = _workflowSteps.First;
            while (currentStep != null)
            {
                Console.WriteLine($"Begin action : {currentStep.Value.Name}");
                await currentStep.Value.Action(message, cancellationToken);
                Console.WriteLine($"End action : {currentStep.Value.Name}");
                currentStep = currentStep.Next;
            }
        }
    }
}
