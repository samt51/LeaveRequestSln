using LeaveRequestApp.Appilication.Dto.LeaveRequestDtos;
using LeaveRequestApp.Appilication.Interfaces;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Appilication.Pattern
{
    public class Strategy
    {
        public class WhiteCollarEmployeeWorkflowStrategy : IWorkflowStrategy
        {
            public WorkflowDescriptionModel DetermineWorkflow(UserTypeEnum userType, LeaveTypeEnum leaveType, Guid employeeId, Guid? managerId)
            {
                return new WorkflowDescriptionModel { WorkflowStatus = WorkflowEnum.Pending, AssignedUserId = managerId };
            }


        }

        public class BlueCollarAnnualLeaveWorkflowStrategy : IWorkflowStrategy
        {
            public WorkflowDescriptionModel DetermineWorkflow(UserTypeEnum userType, LeaveTypeEnum leaveType, Guid employeeId, Guid? managerId)
            {
                return new WorkflowDescriptionModel { WorkflowStatus = WorkflowEnum.Pending, AssignedUserId = managerId };
            }
        }

        public class BlueCollarExcusedAbsenceWorkflowStrategy : IWorkflowStrategy
        {
            public WorkflowDescriptionModel DetermineWorkflow(UserTypeEnum userType, LeaveTypeEnum leaveType, Guid employeeId, Guid? managerId)
            {
               
                return new WorkflowDescriptionModel { WorkflowStatus = WorkflowEnum.Pending, AssignedUserId = managerId };
            }


        }

        public class ManagerWorkflowStrategy : IWorkflowStrategy
        {
            public WorkflowDescriptionModel DetermineWorkflow(UserTypeEnum userType, LeaveTypeEnum leaveType, Guid employeeId, Guid? managerId)
            {
         
                return new WorkflowDescriptionModel { WorkflowStatus = WorkflowEnum.None, AssignedUserId = null };
            }

        }
    }
}
