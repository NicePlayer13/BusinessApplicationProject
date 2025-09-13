using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    /// <summary>
    /// Generic repository interface defining common data access operations.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> Find(Expression<Func<T, bool>> searchTerm);
        Task AddAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
