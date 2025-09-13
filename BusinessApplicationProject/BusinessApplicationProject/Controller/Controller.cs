using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Controller
{
    /// <summary>
    /// Generic controller for managing entity operations via repository pattern.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public class Controller<T> where T : class
    {
        /// <summary>
        /// Delegate to create a new database context.
        /// </summary>
        public delegate AppDbContext AppDbContextFactory();

        /// <summary>
        /// Delegate to create a repository instance.
        /// </summary>
        public delegate IRepository<T> RepositoryFactory(AppDbContext context);

        public required AppDbContextFactory GetContext { get; init; }
        public required RepositoryFactory GetRepository { get; init; }

        /// <summary>
        /// Retrieves all entities.
        /// </summary>
        public IQueryable<T> GetAll()
        {
            var context = GetContext();
            var repository = GetRepository(context);
            return repository.GetAll().AsQueryable();
        }

        /// <summary>
        /// Finds entities that match a given condition.
        /// </summary>
        public IQueryable<T> Find(Expression<Func<T, bool>> condition)
        {
            var context = GetContext();
            var repository = GetRepository(context);
            return repository.Find(condition).AsQueryable();
        }

        /// <summary>
        /// Finds a single entity that matches the given condition.
        /// </summary>
        public T? FindSingle(Expression<Func<T, bool>> condition)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            return repository.Find(condition).FirstOrDefault();
        }

        /// <summary>
        /// Adds a new entity asynchronously.
        /// </summary>
        public async Task AddAsync(T newItem)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            await repository.AddAsync(newItem);
        }

        /// <summary>
        /// Removes an existing entity.
        /// </summary>
        public void Remove(T item)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            repository.Remove(item);
        }

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        public void Update(T item)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            repository.Update(item);
        }
    }
}
