using Ardalis.Specification;
using System.Linq.Expressions;

namespace LeaveRequestApp.Appilication.Interfaces
{
    public interface ISpecifications<T>
    {
        Expression<Func<T, bool>> ToExpression();
    }
}
