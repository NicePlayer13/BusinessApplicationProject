using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessApplicationProject
{
    public static class ServiceConfigurator
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // DbContext
            services.AddScoped<AppDbContext>();

            // Generic repository & controller
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(Controller<>));

            // Temporal repository & controller
            services.AddScoped(typeof(ITemporalRepository<>), typeof(TemporalRepository<>));
            services.AddScoped(typeof(TemporalController<>));

            // Optional: custom repository
            services.AddScoped<ArticleGroupRepository>();

            return services.BuildServiceProvider();
        }
    }
}
