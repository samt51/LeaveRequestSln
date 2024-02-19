using LeaveRequestApp.Domain.Entites;

namespace LeaveRequestApp.Domain.DesignPattern.Factory
{
    public class NotificationsFactory
    {
        public static Notifications CreateNotificationsFactory(Guid? userId, string message, Guid? cumulativeLeaveRequestId)
        {
            if (userId is null && cumulativeLeaveRequestId is null)
            {
                throw new ArgumentNullException("userId is null");
            }

            return new Notifications
            {
                CumulativeLeaveRequestId = cumulativeLeaveRequestId.Value,
                Message = message,
                UserId = userId.Value,
            };
        }
    }
}
