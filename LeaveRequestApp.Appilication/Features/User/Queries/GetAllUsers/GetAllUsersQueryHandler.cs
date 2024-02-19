using Ardalis.Specification;
using LeaveRequestApp.Appilication.Interfaces.AutoMapper;
using LeaveRequestApp.Appilication.Interfaces.UnitOfWorks;
using LeaveRequestApp.Appilication.Pattern.Specifications;
using LeaveRequestApp.Domain.Entites;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage;

namespace LeaveRequestApp.Appilication.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, IList<GetAllUsersQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetAllUsersQueryResponse>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var specification = new UserSpecification();
            var userList = await this.unitOfWork.GetReadRepository<Users>().GetAllAsync(specification.ToExpression());

            var map = _mapper.Map<GetAllUsersQueryResponse, Users>(userList);

            foreach (var item in map)
            {
                if (item.ManagerId is not null)
                {
                    var managerFind = map.Where(x => x.Id == item.ManagerId).FirstOrDefault();
                    item.ManagerFullName = managerFind.FirstName + " " + managerFind.LastName;
                }
            }
            return map;

        }
    }
}
