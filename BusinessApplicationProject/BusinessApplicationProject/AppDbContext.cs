using BusinessApplicationProject;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject
{
    /// <summary>
    /// The database context for the application.
    /// Configures entity relationships and enables temporal tables.
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
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=BusinessApplicationProjectDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Article - ArticleGroup relationship
            modelBuilder.Entity<Article>()
                .HasOne(a => a.Group)
                .WithMany(g => g.Articles)
                .HasForeignKey(a => a.GroupId)
                .OnDelete(DeleteBehavior.Restrict);

            // ArticleGroup - ArticleGroup parent relationship
            modelBuilder.Entity<ArticleGroup>()
                .HasMany(g => g.Articles)
                .WithOne(a => a.Group)
                .HasForeignKey(a => a.GroupId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ArticleGroup>()
                .HasOne(g => g.Parent)
                .WithMany()
                .HasForeignKey(g => g.ParentId)
                .IsRequired(false);

            // Unique customer number
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.CustomerNumber)
                .IsUnique();

            // Customer - Address relationship
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.CustomerAddress)
                .WithMany()
                .HasForeignKey(c => c.CustomerAddressId)
                .OnDelete(DeleteBehavior.Cascade);

            // Order - Customer relationship
            modelBuilder.Entity<Order>()
                .HasOne(o => o.CustomerDetails)
                .WithMany()
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Order - Positions relationship
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Positions)
                .WithOne(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Invoice - Address and Order relationship
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

            // Position - Article and Order relationship
            modelBuilder.Entity<Position>()
                .HasOne(p => p.ArticleDetails)
                .WithMany()
                .HasForeignKey(p => p.ArticleId);

            modelBuilder.Entity<Position>()
                .HasOne(p => p.OrderDetails)
                .WithMany(o => o.Positions)
                .HasForeignKey(p => p.OrderId);

            // Enable temporal table support
            modelBuilder.Entity<Address>().ToTable(nameof(Addresses), b => b.IsTemporal());
            modelBuilder.Entity<Article>().ToTable(nameof(Articles), b => b.IsTemporal());
            modelBuilder.Entity<Customer>().ToTable(nameof(Customers), b => b.IsTemporal());
            modelBuilder.Entity<ArticleGroup>().ToTable(nameof(ArticleGroups), b => b.IsTemporal());
        }
    }
}