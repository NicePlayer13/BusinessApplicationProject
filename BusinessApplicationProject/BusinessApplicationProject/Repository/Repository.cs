using BusinessApplicationProject;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    /// <summary>
    /// Generic repository providing CRUD operations and navigation property resolution.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext Context;

        public Repository(AppDbContext context)
        {
            Context = context;
        }

        public List<T> GetAll()
        {
            if (!Context.Database.CanConnect())
                throw new TimeoutException();

            var query = AddIncludes(typeof(T), Context.Set<T>());
            return query.ToList();
        }

        public List<T> Find(Expression<Func<T, bool>> condition)
        {
            if (!Context.Database.CanConnect())
                throw new TimeoutException();

            var query = AddIncludes(typeof(T), Context.Set<T>());
            return query.Where(condition).ToList();
        }

        public async Task AddAsync(T entity)
        {
            if (!await Context.Database.CanConnectAsync())
                throw new TimeoutException();

            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public void Remove(T entity)
        {
            if (!Context.Database.CanConnect())
                throw new TimeoutException();

            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (!Context.Database.CanConnect())
                throw new TimeoutException();

            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }

        /// <summary>
        /// Adds navigation property includes based on the entity type.
        /// </summary>
        private IQueryable<T> AddIncludes(Type type, IQueryable<T> query)
        {
            foreach (var propertyName in GetAllNavigationPropertyNames(type))
            {
                query = query.Include(propertyName);
            }
            return query;
        }

        /// <summary>
        /// Returns relevant navigation property names for inclusion.
        /// </summary>
        private List<string> GetAllNavigationPropertyNames(Type type)
        {
            return type.Name switch
            {
                nameof(Article) => ["Group.Parent"],
                nameof(ArticleGroup) => ["Parent"],
                nameof(Customer) => ["CustomerAddress"],
                nameof(Invoice) => [
                    "BillingAddress",
                    "OrderInformations.CustomerDetails.CustomerAddress",
                    "OrderInformations.Positions.ArticleDetails.Group.Parent"
                ],
                nameof(Order) => [
                    "CustomerDetails.CustomerAddress",
                    "Positions.ArticleDetails.Group.Parent"
                ],
                nameof(Position) => ["ArticleDetails.Group.Parent"],
                _ => []
            };
        }
    }
}
