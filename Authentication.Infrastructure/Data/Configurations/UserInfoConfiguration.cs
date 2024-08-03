using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    menuId => menuId.Value,
                    dbId => UserInfoId.Of(dbId));

            builder.Property(c => c.FirstName).HasMaxLength(255).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(255).IsRequired();
            builder.Property(c => c.FullName).HasMaxLength(255).IsRequired();
            builder.HasMany(o => o.Items)
                .WithOne()
                .HasForeignKey(oi => oi.UserInfoId);
            builder.HasMany(o => o.ItemMenus)
                .WithOne()
                .HasForeignKey(oi => oi.UserInfoId);
            builder.HasMany(o => o.ItemActions)
               .WithOne()
               .HasForeignKey(oi => oi.UserInfoId);

            builder.Property(c => c.UserInfoCode).HasMaxLength(255).IsRequired();
        }
    }
}
