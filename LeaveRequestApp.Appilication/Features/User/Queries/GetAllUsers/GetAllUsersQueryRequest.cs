using MediatR;

namespace LeaveRequestApp.Appilication.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQueryRequest : IRequest<IList<GetAllUsersQueryResponse>>
    {
        public GetAllUsersQueryRequest()
        {
            
        }
    }
}
