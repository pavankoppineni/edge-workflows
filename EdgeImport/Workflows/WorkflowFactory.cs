using EdgeImport.Workflows.Compensation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeImport.Workflows
{
    public static class WorkflowFactory
    {
        public static IWorkflow CreateWorkflow(WorkflowType workflowType)
        {
            switch (workflowType)
            {
                case WorkflowType.EmployeeCompensation:
                    throw new NotImplementedException();
                case WorkflowType.SalaryStructure:
                    return new SalaryStructureWorkflow();
                case WorkflowType.IndividualTargets:
                    return new IndividualTargetsWorkflow();
                case WorkflowType.EmployeeSalary:
                    throw new NotImplementedException();
            }
            return null;
        }
    }
}
