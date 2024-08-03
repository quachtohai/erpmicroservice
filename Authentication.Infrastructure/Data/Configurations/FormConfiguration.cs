using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class FormConfiguration : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    menuId => menuId.Value,
                    dbId => FormId.Of(dbId));

            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();

            builder.Property(c => c.ModuleCode).HasMaxLength(255).IsRequired();
        }
    }
}
