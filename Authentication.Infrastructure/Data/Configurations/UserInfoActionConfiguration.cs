using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class UserInfoActionConfiguration : IEntityTypeConfiguration<UserInfoAction>
    {
        public void Configure(EntityTypeBuilder<UserInfoAction> builder)
        {
            
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Id).HasConversion(
                        menuId => menuId.Value,
                        dbId => UserInfoActionId.Of(dbId));

                builder.Property(c => c.Name).HasMaxLength(255).IsRequired();

                builder.Property(c => c.ModuleCode).HasMaxLength(255).IsRequired();
                builder.HasOne<ActionInfo>()
                    .WithMany()
                    .HasForeignKey(e => e.ActionInfoId);
            
        }
    }
}
