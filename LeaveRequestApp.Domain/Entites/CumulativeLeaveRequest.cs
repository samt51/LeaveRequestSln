using LeaveRequestApp.Domain.Common;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.Entites
{
    public class CumulativeLeaveRequest : EntityBase
    {
        public LeaveTypeEnum LeaveType { get; set; }
        public Guid UserId { get; set; }
        public Users Users { get; set; }
        public int TotalHours { get; set; }
        public int Year { get; set; }
        public IList<Notifications> Notifications { get; set; }
    }
}
