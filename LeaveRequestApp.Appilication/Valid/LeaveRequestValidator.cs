using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Appilication.Valid
{
    public class LeaveRequestValidator
    {
        public static string ValidateLeaveRequest(LeaveTypeEnum leaveType, int requestedDays)
        {
            int allowedDays = leaveType == LeaveTypeEnum.AnnualLeave ? 14 : 5;
            double threshold = leaveType == LeaveTypeEnum.AnnualLeave ? 0.1 : 0.2;

            if (requestedDays > allowedDays)
            {
                return ($"The requested days ({requestedDays}) exceed the allowed days ({allowedDays}).");
            }

            if (requestedDays > allowedDays * 0.8)
            {
                return ($"You have used {requestedDays * 100 / allowedDays}% of the allowed days for {leaveType}.");
            }

            if (requestedDays > allowedDays * (1 + threshold))
            {
                return ($"The requested days exceed the allowed days by more than {threshold * 100}%. Please contact your manager.");
            }
            return "";
        }
    }
}
