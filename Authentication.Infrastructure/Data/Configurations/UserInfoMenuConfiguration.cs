using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class UserInfoMenuConfiguration : IEntityTypeConfiguration<UserInfoMenu>
    {
        public void Configure(EntityTypeBuilder<UserInfoMenu> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    menuId => menuId.Value,
                    dbId => UserInfoMenuId.Of(dbId));

            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();

            builder.Property(c => c.MenuCode).HasMaxLength(255).IsRequired();
            builder.HasOne<Menu>()
                .WithMany()
                .HasForeignKey(e => e.MenuId);
        }
    }
}
