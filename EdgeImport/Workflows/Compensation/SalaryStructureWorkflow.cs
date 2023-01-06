using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeImport.Workflows.Compensation
{
    public partial class SalaryStructureWorkflow : Workflow, IWorkflow
    {
        public SalaryStructureWorkflow()
        {
            AddStep(nameof(ValidateMinimumValueAsync), ValidateMinimumValueAsync);
            AddStep(nameof(ValidateMaximumValueAsync), ValidateMaximumValueAsync);
            AddStep(nameof(ValidateMidValueAsync), ValidateMidValueAsync);
        }
    }
}
