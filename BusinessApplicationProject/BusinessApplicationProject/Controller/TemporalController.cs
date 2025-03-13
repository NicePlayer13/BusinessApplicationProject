using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Temporal controller class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TemporalController<T> : Controller<T> where T : class
    {
        // Define a delegate for the temporal repository
        public delegate ITemporalRepository<T> TemporalRepositoryFactory(AppDbContext context);

        public required TemporalRepositoryFactory GetTemporalRepository { get; init; }


        public List<T> FindAsOf(DateTime timestamp, Expression<Func<T, bool>> condition)
        {
            using var context = GetContext();
            var repository = GetTemporalRepository(context);
            return repository.FindAsOf(timestamp, condition).ToList();
        }
    }
}
