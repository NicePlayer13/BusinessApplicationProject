using BusinessApplicationProject.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject
{
    /// <summary>
    /// The database context for the application.
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleGroup> ArticleGroups { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BusinessApplicationProjectDB;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>()
        .HasOne(a => a.Group)
        .WithMany(g => g.Articles)
        .HasForeignKey(a => a.GroupId)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ArticleGroup>()
        .HasMany(g => g.Articles) // ✅ One-to-Many Relationship
        .WithOne(a => a.Group) // Each Article belongs to ONE Group
        .HasForeignKey(a => a.GroupId)
        .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
            modelBuilder.Entity<ArticleGroup>()
       .HasOne(g => g.Parent)
       .WithMany()
       .HasForeignKey(g => g.ParentId)
       .IsRequired(false);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.CustomerAddress)
                .WithMany()
                .HasForeignKey(c => c.CustomerAddressId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
     .HasOne(o => o.CustomerDetails)
     .WithMany()
     .HasForeignKey(o => o.CustomerId)
     .OnDelete(DeleteBehavior.Restrict); // ✅ Ensure no cascade delete issue

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Positions)
                .WithOne(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);  // ✅ Ensure correct delete behavior


            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.BillingAddress)
                .WithMany()
                .HasForeignKey(i => i.BillingAddressId)
                    .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.OrderInformations)
                .WithMany()
                .HasForeignKey(i => i.OrderId)
                    .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Position>()
                .HasOne(p => p.ArticleDetails)
                .WithMany()
                .HasForeignKey(p => p.ArticleId);

            modelBuilder.Entity<Position>()
                .HasOne(p => p.OrderDetails)
                .WithMany(o => o.Positions)
                .HasForeignKey(p => p.OrderId);

            // Keep this ONLY if you explicitly need temporal tables
            modelBuilder.Entity<Address>().ToTable(nameof(Addresses), b => b.IsTemporal());
            modelBuilder.Entity<Article>().ToTable(nameof(Articles), b => b.IsTemporal());
        }
    }
}
