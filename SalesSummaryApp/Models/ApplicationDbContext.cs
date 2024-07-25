using Microsoft.EntityFrameworkCore;
using SalesSummaryApp.Models;

namespace SalesSummaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SalesSummary> SalesSummaries { get; set; }
    }
}
