using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Appilication.Dto.LeaveRequestDtos
{
    public class WorkflowDescriptionModel
    {
        public WorkflowEnum WorkflowStatus { get; set; }
        public Guid? AssignedUserId { get; set; }
    }
}
