using LeaveRequestApp.Domain.Common;

namespace LeaveRequestApp.Domain.Entites
{
    public class Notifications :EntityBase
    {
        public Guid UserId { get; set; }
        public Users Users { get; set; }
        public string Message { get; set; }
        public Guid? CumulativeLeaveRequestId { get; set; }
        public CumulativeLeaveRequest CumulativeLeaveRequest { get; set; }

    }
}
