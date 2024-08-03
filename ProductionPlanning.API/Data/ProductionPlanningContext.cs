using Microsoft.EntityFrameworkCore;
using ProductionPlanning.API.Models;

namespace ProductionPlanning.API.Data
{
    public class ProductionPlanningContext : DbContext
    {
        public DbSet<BillOfMaterial> BillOfMaterials { get; set; } = default!;
        public DbSet<BillOfMaterialDetail> BillOfMaterialDetails { get; set; } = default!;

        public ProductionPlanningContext(DbContextOptions<ProductionPlanningContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
