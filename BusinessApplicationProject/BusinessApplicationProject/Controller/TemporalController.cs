using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Temporal controller for querying historical data using temporal tables.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public class TemporalController<T> : Controller<T> where T : class
    {
        /// <summary>
        /// Delegate to create a temporal repository instance.
        /// </summary>
        public delegate ITemporalRepository<T> TemporalRepositoryFactory(AppDbContext context);

        /// <summary>
        /// Factory delegate used to retrieve the temporal repository.
        /// </summary>
        public required TemporalRepositoryFactory GetTemporalRepository { get; init; }

        /// <summary>
        /// Retrieves a list of entities as they existed at a specific point in time.
        /// </summary>
        /// <param name="timestamp">The point in time to query.</param>
        /// <param name="condition">Optional condition to filter results.</param>
        /// <returns>List of matching historical entities.</returns>
        public List<T> FindAsOf(DateTime timestamp, Expression<Func<T, bool>> condition)
        {
            using var context = GetContext();
            var repository = GetTemporalRepository(context);
            return repository.FindAsOf(timestamp, condition).ToList();
        }
    }
}
