using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    /// <summary>
    /// Interface for temporal repositories supporting point-in-time queries.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public interface ITemporalRepository<T> : IRepository<T> where T : class
    {
        IEnumerable<T> GetAllAsOf(DateTime timestamp);
        IEnumerable<T> FindAsOf(DateTime timestamp, Expression<Func<T, bool>> condition);
    }
}
