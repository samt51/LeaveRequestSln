using LeaveRequestApp.Appilication.Features.Notifications.Queries.GetAllNotification;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveRequestApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<GetAllNotificationQueryResponse>> GetAllNotifications(GetAllNotificationQueryRequest request)
        {
            var data = await _mediator.Send(request);
            return data.ToList();
        }
    }
}
