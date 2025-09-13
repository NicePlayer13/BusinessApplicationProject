using BusinessApplicationProject.Controller;
using BusinessApplicationProject;
using BusinessApplicationProject.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Configures dependency injection for the application.
    /// </summary>
    public static class ServiceConfigurator
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<AppDbContext>();

            // Register generic controllers and repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(Controller<>));
            services.AddScoped(typeof(ITemporalRepository<>), typeof(TemporalRepository<>));
            services.AddScoped(typeof(TemporalController<>));

            // Register custom repositories
            services.AddScoped<ArticleGroupRepository>();

            return services.BuildServiceProvider();
        }
    }
}
