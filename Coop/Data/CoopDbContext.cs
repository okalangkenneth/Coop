using Coop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Data
{
    public class CoopDbContext : DbContext
    {
        public DbSet<ProduceType> ProduceTypes { get; set; }
        public DbSet<Feature> Features { get; set; }

       
        public CoopDbContext(DbContextOptions<CoopDbContext> options) 
            : base(options)
      {

      }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProduceFeature>().HasKey(vf =>
              new { vf.ProduceId, vf.FeatureId });
        }

    }
}
