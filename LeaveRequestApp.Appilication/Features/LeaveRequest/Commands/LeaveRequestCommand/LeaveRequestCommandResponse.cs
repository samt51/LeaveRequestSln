namespace LeaveRequestApp.Appilication.Features.LeaveRequest.Commands.LeaveRequestCommand
{
    public class LeaveRequestCommandResponse
    {
        public LeaveRequestCommandResponse(string response)
        {
            this.Response = response;
        }
        public string Response { get; set; }
    }
}
