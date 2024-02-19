using LeaveRequestApp.Domain.Entites;

namespace LeaveRequestApp.Domain.Events.LeaveRequestEvent
{
    public class LeaveRequestCreatedEvent : IDomainEvent
    {
        public LeaveRequest LeaveRequest { get; set; }

        public LeaveRequestCreatedEvent(LeaveRequest leaveRequest)
        {
            LeaveRequest = leaveRequest;
        }
    }
}
