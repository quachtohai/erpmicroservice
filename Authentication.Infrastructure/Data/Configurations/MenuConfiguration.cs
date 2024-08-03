using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    menuId => menuId.Value,
                    dbId => MenuId.Of(dbId));

            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();

            builder.Property(c => c.MenuCode).HasMaxLength(255).IsRequired();
            

        }
    }
}
