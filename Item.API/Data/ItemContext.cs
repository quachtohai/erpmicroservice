using Item.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Item.API.Data
{
    public class ItemContext : DbContext
    {
        public DbSet<MaterialInfo> MaterialInfos { get; set; } = default!;

        public ItemContext(DbContextOptions<ItemContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaterialInfo>().HasData(
                new MaterialInfo { Id = 1, MaterialCode = "AluminumFrame", MaterialName = "Aluminum Frame", Description = "Aluminum Frame", IsActive = true },
                new MaterialInfo { Id = 2, MaterialCode = "GlassPane", MaterialName = "Glass Pane", Description = "Glass Pane", IsActive = true },
                new MaterialInfo { Id = 3, MaterialCode = "Latch", MaterialName = "Latch", Description = "Latch", IsActive = true }
                );
        }
    }
}
