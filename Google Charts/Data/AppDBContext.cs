using Microsoft.EntityFrameworkCore;

namespace Google_Charts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPieChart> BlogPieCharts { get; set; }

    }
}
