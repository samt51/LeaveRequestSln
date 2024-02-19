namespace LeaveRequestApp.Domain.Events
{
    public interface IEventListener<TEvent> where TEvent : IDomainEvent
    {
        bool Handle(TEvent domainEvent);
    }
}
