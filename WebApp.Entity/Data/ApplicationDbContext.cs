using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebApp.Sales.Models;

namespace WebApp.Sales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne<Customer>(s => s.Customer)
                .WithMany(g => g.Orders)
                .HasForeignKey(s => s.CustomerId);
        }
        public DbSet<Order> order { get; set; }
        public DbSet<Sale> sales { get; set; }

        public DbSet<Customer> Customer { get; set; }
        
    }
}
