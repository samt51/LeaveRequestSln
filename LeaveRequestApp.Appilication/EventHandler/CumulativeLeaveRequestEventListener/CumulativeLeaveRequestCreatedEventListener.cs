using LeaveRequestApp.Domain.Events.CumulativeLeaveRequestEvent;
using LeaveRequestApp.Domain.Events;
using LeaveRequestApp.Appilication.Interfaces.UnitOfWorks;
using LeaveRequestApp.Domain.Entites;
using LeaveRequestApp.Appilication.Valid;

namespace LeaveRequestApp.Appilication.EventHandler.CumulativeLeaveRequestEventListener
{
    public class CumulativeLeaveRequestCreatedEventListener : IEventListener<CumulativeLeaveRequestCreatedEvent>
    {
        private readonly IUnitOfWork unitOfWork;

        public CumulativeLeaveRequestCreatedEventListener(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool Handle(CumulativeLeaveRequestCreatedEvent domainEvent)
        {
            this.unitOfWork.GetWriteRepository<CumulativeLeaveRequest>().AddAsync(domainEvent.CumulativeLeaveRequest);
            if (this.unitOfWork.Save() > 0)
            {
                return true;
            }
            return false;
        }
    }

}
