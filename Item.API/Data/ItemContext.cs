using Item.API.Models;
using Microsoft.EntityFrameworkCore;


namespace Item.API.Data
{
    public class ItemContext : DbContext
    {
        public DbSet<MaterialInfo> MaterialInfos { get; set; } = default!;
        public DbSet<Models.Product> Products { get; set; } = default!;
        public DbSet<Models.DictionaryInfo> DictionaryInfos { get; set; } = default!;

        public ItemContext(DbContextOptions<ItemContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MaterialInfo>().HasData(
            //    new MaterialInfo { Id = 1, MaterialCode = "AluminumFrame", MaterialName = "Aluminum Frame", Description = "Aluminum Frame", IsActive = true },
            //    new MaterialInfo { Id = 2, MaterialCode = "GlassPane", MaterialName = "Glass Pane", Description = "Glass Pane", IsActive = true },
            //    new MaterialInfo { Id = 3, MaterialCode = "Latch", MaterialName = "Latch", Description = "Latch", IsActive = true }
            //    );
            modelBuilder.Entity<Models.Product>().HasKey(x=>x.Id);
            modelBuilder.Entity<MaterialInfo>().HasKey(x=>x.Id);
            modelBuilder.Entity<Models.DictionaryInfo>().HasKey(x=>x.Id);
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.DictionaryInfoCode).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.Description2).HasMaxLength(500);
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.Description3).HasMaxLength(500);
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.Description4).HasMaxLength(500);
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.Description5).HasMaxLength(500);
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.Description6).HasMaxLength(500);
            modelBuilder.Entity<Models.DictionaryInfo>().
                Property(c => c.Process).HasMaxLength(500);

            modelBuilder.Entity<Models.Product>().
                 Property(c => c.ProductCode01).HasMaxLength(255);

            modelBuilder.Entity<Models.Product>().
                 Property(c => c.ProductCode02).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.ProductName).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Description).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Description2).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Description3).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Description4).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Description5).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Description6).HasMaxLength(255);
            modelBuilder.Entity<Models.Product>().
                Property(c => c.Process).HasMaxLength(255);



        }
    }
}
