using Batur.JwtApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Batur.JwtApp.Back.Persistance.Configrations
{
    public class AppUserConfigration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(x=>x.AppRole).WithMany(x=>x.AppUsers).HasForeignKey(x=>x.AppRoleId);
        }
    }
   
}
