using LeaveRequestApp.Appilication.Features.User.Queries.GetAllUsers;

namespace LeaveRequestApp.Appilication.Features.Notifications.Queries.GetAllNotification
{
    public class GetAllNotificationQueryResponse
    {
        public GetAllUsersQueryResponse Users { get; set; }
        public string Message { get; set; }
        public Guid? CumulativeLeaveRequestId { get; set; }
    }
}
