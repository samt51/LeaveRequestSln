using LeaveRequestApp.Domain.Entites;
using LeaveRequestApp.Domain.Enums;

namespace LeaveRequestApp.Domain.DesignPattern.Factory
{
    public class UsersFactory
        {
            public static Users CreateUser(string firstName, string lastName, string email, UserTypeEnum userType, Guid? managerId)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("First name, last name, and email cannot be empty.");
            }


            return new Users
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserType = userType,
                ManagerId = managerId
            };
        }
    }
}


