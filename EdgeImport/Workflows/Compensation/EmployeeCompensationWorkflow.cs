using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeImport.Workflows.Compensation
{
    public partial class EmployeeCompensationWorkflow : Workflow, IWorkflow
    {
        public EmployeeCompensationWorkflow()
        {
            AddStep(nameof(ValidateWageTypeAsync), ValidateWageTypeAsync);
            AddStep(nameof(ValidateCompensationAmountAsync), ValidateCompensationAmountAsync);
        }
    }
}
