using LeaveRequestApp.Appilication.Dto.LeaveRequestDtos;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Appilication.Interfaces
{
    public interface IWorkflowStrategy
    {
        WorkflowDescriptionModel DetermineWorkflow(UserTypeEnum userType, LeaveTypeEnum leaveType, Guid employeeId, Guid? managerId);
    }
}
