namespace LeaveRequestApp.Appilication.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQueryResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public Guid? ManagerId { get; set; }
        public string ManagerFullName { get; set; }
    }
}
