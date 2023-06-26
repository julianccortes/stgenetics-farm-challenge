using Microsoft.EntityFrameworkCore;
using STgenetics.Farm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Infrastructure.Context
{
    public class ApplicationFarmContext : DbContext
    {
        public ApplicationFarmContext(DbContextOptions<ApplicationFarmContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
