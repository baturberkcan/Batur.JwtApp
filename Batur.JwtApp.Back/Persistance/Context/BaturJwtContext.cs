using Batur.JwtApp.Back.Core.Domain;
using Batur.JwtApp.Back.Persistance.Configrations;
using Microsoft.EntityFrameworkCore;

namespace Batur.JwtApp.Back.Persistance.Context
{
    public class BaturJwtContext : DbContext
    {
        public BaturJwtContext(DbContextOptions<BaturJwtContext> options) : base(options)
        {

        }
        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfigration());
            modelBuilder.ApplyConfiguration(new AppUserConfigration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
