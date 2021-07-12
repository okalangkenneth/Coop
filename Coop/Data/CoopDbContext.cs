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
      public CoopDbContext(DbContextOptions<CoopDbContext> options) 
            : base(options)
      {

      }
        public DbSet<ProduceType> ProduceType { get; set; }
        
    }
}
