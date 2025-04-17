using Microsoft.EntityFrameworkCore;
using WebApp.Sales.Models;

namespace WebApp.Sales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Sale> Sales { get; set; }
    }
}
