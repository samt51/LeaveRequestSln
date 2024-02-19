using LeaveRequestApp.Domain.Entites;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.DesignPattern.Factory
{
    public class CumulativeLeaveRequestFactory
    {
        public static CumulativeLeaveRequest CreateCumulativeLeaveRequest(LeaveTypeEnum leaveType, Guid? userId, decimal totalHours, int year)
        {
            if (userId == null)
            {
                throw new ArgumentNullException("userId is null");
            }

            return new CumulativeLeaveRequest
            {
                LeaveType = leaveType,
                TotalHours = totalHours,
                UserId = userId.Value,
                Year = year,
            };
        }
    }
}
