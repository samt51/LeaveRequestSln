using LeaveRequestApp.Domain.Common;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.Entites
{
    public class Users : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserTypeEnum UserType { get; set; }
        public Guid? ManagerId { get; set; }
        public IList<Notifications> Notifications { get; set; }
        public IList<LeaveRequest> AssignedUsers { get; set; }
        public IList<LeaveRequest> CreatedByIds { get; set; }
        public IList<LeaveRequest> LastModifiedByIds { get; set; }
        public IList<Permissions> Permissions { get; set; }
    }
}
