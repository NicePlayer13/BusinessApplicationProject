using BusinessApplicationProject.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BusinessApplicationProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                     
            ApplicationConfiguration.Initialize();
            using (var context = new AppDbContext())
            {
                context.Database.Migrate(); 
                DataSeeder.SeedDatabase(context);
            }
            Application.Run(new FormMain());
        }
    }
}