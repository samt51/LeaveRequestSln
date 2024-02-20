namespace LeaveRequestApp.Domain.Events
{
    public interface IEventListener
    {
        bool CanHandle(IDomainEvent domainEvent);
        bool Handle(IDomainEvent domainEvent);
    }

}
