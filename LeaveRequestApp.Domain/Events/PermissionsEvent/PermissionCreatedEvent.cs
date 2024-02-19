using LeaveRequestApp.Domain.Entites;

namespace LeaveRequestApp.Domain.Events.PermissionsEvent
{
    public class PermissionCreatedEvent : IDomainEvent
    {
        public Permissions Permissions { get; set; }

        public PermissionCreatedEvent(Permissions permissions)
        {
            this.Permissions = permissions;
        }
    }
}
