using LeaveRequestApp.Appilication.Interfaces;
using LeaveRequestApp.Domain.Entites;

namespace LeaveRequestApp.Appilication.Pattern.Specifications
{
    public class UserSpecification : ISpecifications<Users>
    {
        public System.Linq.Expressions.Expression<Func<Users, bool>> ToExpression()
        {
            return user => !user.IsDeleted;
        }
    }
}
 