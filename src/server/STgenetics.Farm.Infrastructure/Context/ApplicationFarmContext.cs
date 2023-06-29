using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using STgenetics.Farm.Domain.Entities;

namespace STgenetics.Farm.Infrastructure.Context
{
    public class ApplicationFarmContext : DbContext
    {
        public ApplicationFarmContext(DbContextOptions<ApplicationFarmContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Animal> Animal { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var property in builder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,6)");
            }

            builder.Entity<Animal>().Property(e => e.Id).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
            base.OnModelCreating(builder);
        }
    }
}
