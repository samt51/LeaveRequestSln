using LeaveRequestApp.Domain.Common;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.Entites
{
    public class LeaveRequest : EntityBase
    {
        public LeaveTypeEnum LeaveType { get; set; }
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public WorkflowEnum WorkflowStatus { get; set; }
        public Guid? AssignedUserId { get; set; }
        public Users Users { get; set; }
        public Guid CreatedById { get; set; }
        public Users CreatedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; } =DateTime.Now;
        public Guid LastModifiedById { get; set; }
        public Users LastModifiedByUser { get; set; }


    }
}
