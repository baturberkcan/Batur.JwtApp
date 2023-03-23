using Batur.JwtApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Batur.JwtApp.Back.Persistance.Configrations
{
    public class ProductConfigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Category).WithMany(z => z.Products).HasForeignKey(x => x.CategoryId); 
        }
    }
}
