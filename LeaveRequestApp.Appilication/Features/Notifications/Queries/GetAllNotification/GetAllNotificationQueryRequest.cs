using LeaveRequestApp.Appilication.Features.User.Queries.GetAllUsers;
using MediatR;

namespace LeaveRequestApp.Appilication.Features.Notifications.Queries.GetAllNotification
{
    public class GetAllNotificationQueryRequest : IRequest<IList<GetAllNotificationQueryResponse>>
    {
        public GetAllNotificationQueryRequest()
        {
                
        }
    }
}
