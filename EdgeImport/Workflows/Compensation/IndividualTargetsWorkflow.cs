using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeImport.Workflows.Compensation
{
    public partial class IndividualTargetsWorkflow : Workflow, IWorkflow
    {
        public IndividualTargetsWorkflow()
        {
            AddStep(nameof(ValidateTargetNameAsync), ValidateTargetNameAsync);
            AddStep(nameof(ValidateTargetDateAsync), ValidateTargetDateAsync);
            AddStep(nameof(ValidateTargetTypeAsync), ValidateTargetTypeAsync);
        }
    }
}
