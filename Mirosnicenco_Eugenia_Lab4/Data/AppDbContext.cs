using Microsoft.EntityFrameworkCore;
using Mirosnicenco_Eugenia_Lab4.Models;

namespace Mirosnicenco_Eugenia_Lab4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
 : base(options)
        {
        }
        public DbSet<PredictionHistory> PredictionHistories { get; set; }
    }
}
