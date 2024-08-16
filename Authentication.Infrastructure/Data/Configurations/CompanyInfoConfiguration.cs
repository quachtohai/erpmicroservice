using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class CompanyInfoConfiguration : IEntityTypeConfiguration<CompanyInfo>
    {
        public void Configure(EntityTypeBuilder<CompanyInfo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    menuId => menuId.Value,
                    dbId => CompanyInfoId.Of(dbId));

            builder.Property(c => c.Name).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Contact).HasMaxLength(500);
            builder.Property(c => c.Country).HasMaxLength(500);
            builder.Property(c => c.Phone).HasMaxLength(500);
            builder.Property(c => c.Email).HasMaxLength(500);
            builder.Property(c => c.Website).HasMaxLength(500);



        }
    }
}
