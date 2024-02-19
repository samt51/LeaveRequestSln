using LeaveRequestApp.Domain.Events.CumulativeLeaveRequestEvent;
using LeaveRequestApp.Domain.Events;
using LeaveRequestApp.Domain.Events.PermissionsEvent;
using LeaveRequestApp.Appilication.Interfaces.UnitOfWorks;

namespace LeaveRequestApp.Appilication.EventHandler.PermissionEventListener
{
    public class PermissionCreatedEventListener : IEventListener<PermissionCreatedEvent>
    {
        private readonly IUnitOfWork unitOfWork;

        public PermissionCreatedEventListener(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool Handle(PermissionCreatedEvent domainEvent)
        {
            throw new NotImplementedException();
        }
    }
}
