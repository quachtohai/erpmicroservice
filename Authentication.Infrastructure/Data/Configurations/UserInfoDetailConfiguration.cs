using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Data.Configurations
{
    public class UserInfoDetailConfiguration : IEntityTypeConfiguration<UserInfoDetail>
    {
        

        public void Configure(EntityTypeBuilder<UserInfoDetail> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                    userInfoDetailId => userInfoDetailId.Value,
                    dbId => UserInfoDetailId.Of(dbId));
            builder.Property(c => c.UserInfoId).IsRequired();
            builder.Property(c => c.AccountCode).HasMaxLength(255).IsRequired();
            builder.Property(c => c.AccountName).HasMaxLength(255).IsRequired();
            builder.Property(c => c.Password).HasMaxLength(255).IsRequired();
           

        }
    }
}
