using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class ActionInfoConfiguration : IEntityTypeConfiguration<ActionInfo>
    {
        public void Configure(EntityTypeBuilder<ActionInfo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    menuId => menuId.Value,
                    dbId => ActionInfoId.Of(dbId));

            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();

            builder.Property(c => c.ActionCode).HasMaxLength(255).IsRequired();
        }
    }
}
