using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    /// <summary>
    /// Generic repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TemporalRepository<T> : Repository<T>, ITemporalRepository<T> where T : class
    {
        public TemporalRepository(AppDbContext context) : base(context) { }

        public IEnumerable<T> GetAllAsOf(DateTime timestamp)
        {
            return Context.Set<T>().TemporalAsOf(timestamp);
        }

        public IEnumerable<T> FindAsOf(DateTime timestamp, Expression<Func<T, bool>> condition)
        {
            return Context.Set<T>().TemporalAsOf(timestamp).Where<T>(condition);
        }
    }
}