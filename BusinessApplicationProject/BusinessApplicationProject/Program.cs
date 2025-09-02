using BusinessApplicationProject.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessApplicationProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ServiceConfigurator.ConfigureServices();

            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.Migrate();
                DataSeeder.SeedDatabase(context);
            }

            // Beispiel: Controller injizieren
            // var controller = serviceProvider.GetRequiredService<Controller<Customer>>();

            Application.Run(new FormMain());
        }
    }
}
