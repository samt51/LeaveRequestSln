using LeaveRequestApp.Domain.Enums;
using MediatR;

namespace LeaveRequestApp.Appilication.Features.LeaveRequest.Commands.LeaveRequestCommand
{
    public class LeaveRequestCommandRequest : IRequest<LeaveRequestCommandResponse>
    {
        public LeaveRequestCommandRequest(Guid employeeId, LeaveTypeEnum leaveType, DateTime startDate, DateTime endDate, string reason)
        {
            EmployeeId = employeeId;
            LeaveType = leaveType;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
        public Guid EmployeeId { get; }
        public LeaveTypeEnum LeaveType { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public string Reason { get; }
    }
}
