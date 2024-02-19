using LeaveRequestApp.Appilication.Interfaces;
using LeaveRequestApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeaveRequestApp.Appilication.Pattern.Strategy;

namespace LeaveRequestApp.Appilication.Pattern.Factory
{
    public class WorkflowStrategyFactory
    {
        public static IWorkflowStrategy CreateWorkflowStrategy(UserTypeEnum userType, LeaveTypeEnum leaveType)
        {
            switch (userType)
            {
                case UserTypeEnum.WhiteCollarEmployee:
                    return new WhiteCollarEmployeeWorkflowStrategy();
                case UserTypeEnum.BlueCollarEmployee when leaveType == LeaveTypeEnum.AnnualLeave:
                    return new BlueCollarAnnualLeaveWorkflowStrategy();
                case UserTypeEnum.BlueCollarEmployee when leaveType == LeaveTypeEnum.ExcusedAbsence:
                    return new BlueCollarExcusedAbsenceWorkflowStrategy();
                case UserTypeEnum.Manager:
                    return new ManagerWorkflowStrategy();
                default:
                    throw new ArgumentException("Invalid UserType or LeaveType combination");
            }
        }
    }

}
