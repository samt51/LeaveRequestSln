using LeaveRequestApp.Appilication.Dto.LeaveRequestDtos;
using LeaveRequestApp.Appilication.EventHandler.CumulativeLeaveRequestEventListener;
using LeaveRequestApp.Appilication.Interfaces.AutoMapper;
using LeaveRequestApp.Appilication.Interfaces.Repositories;
using LeaveRequestApp.Appilication.Interfaces.UnitOfWorks;
using LeaveRequestApp.Appilication.Pattern.Factory;
using LeaveRequestApp.Appilication.Valid;
using LeaveRequestApp.Domain.Entites;
using LeaveRequestApp.Domain.Enums;
using LeaveRequestApp.Domain.Events;
using LeaveRequestApp.Domain.Events.CumulativeLeaveRequestEvent;
using LeaveRequestApp.Domain.Events.LeaveRequestEvent;
using MediatR;

namespace LeaveRequestApp.Appilication.Features.LeaveRequest.Commands.LeaveRequestCommand
{
    public class LeaveRequestCommandHandler : IRequestHandler<LeaveRequestCommandRequest, LeaveRequestCommandResponse>
    {
        private readonly EventDispatcher _eventDispatcher;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LeaveRequestCommandHandler(IMapper mapper, EventDispatcher eventDispatcher, IUnitOfWork unitOfWork)
        {
            _eventDispatcher = eventDispatcher;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<LeaveRequestCommandResponse> Handle(LeaveRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var map = _mapper.Map<LeaveRequestApp.Domain.Entites.LeaveRequest, LeaveRequestCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<LeaveRequestApp.Domain.Entites.LeaveRequest>().AddAsync(map);
            if (await _unitOfWork.SaveAsync() > 0)
            {
                _eventDispatcher.Dispatch(new LeaveRequestCreatedEvent(map));

                var cumulativeLeaveRequest = new CumulativeLeaveRequest
                {
                    LeaveType = map.LeaveType,
                    UserId = map.Id,
                    TotalHours = CalculateTotalHours(map.StartDate, map.EndDate),
                    Year = map.StartDate.Year
                };

                var cumulativeLeaveRequestEvent = new CumulativeLeaveRequestCreatedEvent(cumulativeLeaveRequest);
                bool isEventDispatchedSuccessfully = _eventDispatcher.Dispatch(cumulativeLeaveRequestEvent);

                if (isEventDispatchedSuccessfully)
                {
                    var getPermissionDetailByEmployeeId = await _unitOfWork.GetReadRepository<Permissions>().GetAsync(x => x.EmployeeId == map.Id && x.LeaveTypeEnum == map.LeaveType);
                    if (getPermissionDetailByEmployeeId != null)
                    {
                        getPermissionDetailByEmployeeId.TotalPermission += CalculateTotalHours(map.StartDate, map.EndDate);
                        getPermissionDetailByEmployeeId.RemainderPermission -= CalculateTotalHours(map.StartDate, map.EndDate);
                    }
                    else
                    {
                        var permissionRequest = new Permissions
                        {
                            LeaveTypeEnum = map.LeaveType,
                            EmployeeId = map.Id,
                            Year = map.StartDate.Year,
                            TotalPermission = CalculateTotalHours(map.StartDate, map.EndDate),
                        };
                    }


                    var notification = LeaveRequestValidator.ValidateLeaveRequest(cumulativeLeaveRequest.LeaveType, cumulativeLeaveRequest.TotalHours);
                    var requestt = new Notifications
                    {
                        CumulativeLeaveRequestId = cumulativeLeaveRequest.Id,
                        Message = notification,
                        UserId = map.Id,
                    };
                    await _unitOfWork.GetWriteRepository<Notifications>().AddAsync(requestt);
                    if (await _unitOfWork.SaveAsync() > 0)
                    {
                        await _unitOfWork.SaveAsync();
                        return new LeaveRequestCommandResponse("success");
                    }


                }
            }
            return new LeaveRequestCommandResponse("failed");
        }
        private int CalculateTotalHours(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeDifference = endDate - startDate;
            int totalDays = (int)timeDifference.TotalDays;
            return totalDays;
        }
        private WorkflowDescriptionModel DetermineWorkflow(UserTypeEnum userType, LeaveTypeEnum leaveType, Guid employeeId, Guid? managerId)
        {
            // İş akışı stratejisini oluştur
            var workflowStrategy = WorkflowStrategyFactory.CreateWorkflowStrategy(userType, leaveType);

            // İş akışını belirle
            return workflowStrategy.DetermineWorkflow(userType, leaveType, employeeId, managerId);
        }
    }
}
