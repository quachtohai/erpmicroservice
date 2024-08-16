using Microsoft.EntityFrameworkCore;
using ReportingService.Models;

namespace ReportingService.Datas
{

    public class ReportingContext : DbContext
    {
        public DbSet<DailyReport> DailyReports { get; set; }

        public ReportingContext(DbContextOptions<ReportingContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyReport>().HasNoKey();
        }
    }

}
