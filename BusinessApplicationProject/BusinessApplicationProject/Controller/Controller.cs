using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Controller
{

    /// <summary>
    /// Generic controller class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Controller<T> where T : class
    {
        public delegate AppDbContext AppDbContextFactory();
        public delegate IRepository<T> RepositoryFactory(AppDbContext context);

        public required AppDbContextFactory GetContext { get; init; }  
        public required RepositoryFactory GetRepository { get; init; }

        public List<T> GetAll()
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            return repository.GetAll();
        }

        public List<T> Find(Expression<Func<T, bool>> condition)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            return repository.Find(condition);
        }

        public T? FindSingle(Expression<Func<T, bool>> condition)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            return repository.Find(condition).FirstOrDefault();
        }

        public async Task AddAsync(T newItem)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            await repository.AddAsync(newItem);
        }

        public void Remove(T item)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            repository.Remove(item);
        }

        public void Update(T item)
        {
            using var context = GetContext();
            var repository = GetRepository(context);
            repository.Update(item);
        }
    }
}
