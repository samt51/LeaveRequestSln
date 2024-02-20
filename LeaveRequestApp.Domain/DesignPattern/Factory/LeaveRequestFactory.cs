using LeaveRequestApp.Domain.Entites;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.DesignPattern.Factory
{
    public class LeaveRequestFactory
    {
        public static LeaveRequest CreateLeaveRequest(LeaveTypeEnum leaveType, string reason, DateTime startDate, DateTime endDate, WorkflowEnum workFlowStatus,
            Guid? assignedUserId, Guid CreateUserId,
            Guid lastModifiedUserId)
        {
            return new LeaveRequest
            {
                StartDate = startDate,
                WorkflowStatus = workFlowStatus,
                AssignedUserId = assignedUserId,
                CreatedByUserId = CreateUserId,
                EndDate = endDate,
                LastModifiedById = lastModifiedUserId,
                Reason = reason,
                LeaveType = leaveType
            };
        }
    }
}
