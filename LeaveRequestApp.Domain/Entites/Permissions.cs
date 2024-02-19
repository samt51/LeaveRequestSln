using LeaveRequestApp.Domain.Common;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.Entites
{
    public class Permissions : EntityBase
    {
        public Guid EmployeeId { get; set; }
        public Users Users { get; set; }
        public int Year { get; set; }
        public LeaveTypeEnum  LeaveTypeEnum { get; set; }
        public decimal TotalPermission { get; set; }
        public decimal RemainderPermission { get; set; }

    }
}
