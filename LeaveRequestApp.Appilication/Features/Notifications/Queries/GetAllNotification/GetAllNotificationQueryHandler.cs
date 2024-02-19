using LeaveRequestApp.Appilication.Features.User.Queries.GetAllUsers;
using LeaveRequestApp.Appilication.Interfaces.AutoMapper;
using LeaveRequestApp.Appilication.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LeaveRequestApp.Appilication.Features.Notifications.Queries.GetAllNotification
{
    public class GetAllNotificationQueryHandler : IRequestHandler<GetAllNotificationQueryRequest, IList<GetAllNotificationQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllNotificationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllNotificationQueryResponse>> Handle(GetAllNotificationQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.GetReadRepository<LeaveRequestApp.Domain.Entites.Notifications>().GetAllByPagingAsync(x => x.IsDeleted == false, x => x.Include(x => x.Users).ThenInclude(y => y.Notifications));

            var mapList = _mapper.Map<GetAllNotificationQueryResponse, LeaveRequestApp.Domain.Entites.Notifications>(list);

            return mapList.ToList();
        }
    }
}
