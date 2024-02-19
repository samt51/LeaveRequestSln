using LeaveRequestApp.Domain.Entites;

namespace LeaveRequestApp.Domain.Events.CumulativeLeaveRequestEvent
{
    public class CumulativeLeaveRequestCreatedEvent : IDomainEvent
    {
        public CumulativeLeaveRequest CumulativeLeaveRequest { get; set; }

        public CumulativeLeaveRequestCreatedEvent(CumulativeLeaveRequest cumulativeLeaveRequest)
        {
            CumulativeLeaveRequest = cumulativeLeaveRequest;
        }
    }
}
