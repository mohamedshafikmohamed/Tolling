using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Models;

namespace Tolling.Data
{
    public class Dbcontext:DbContext
    {
        public Dbcontext(DbContextOptions options)
           : base(options)
        {

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationDetails>().HasKey(sc => new { sc.LocationId, sc.SerialNumber });
            modelBuilder.Entity<ToolPart>().HasKey(sc => new { sc.SerialNumber, sc.PartNumber });
        }
        public DbSet<User>Users{ get; set; }
        public DbSet<Location> Location{ get; set; }
        public DbSet<Locker> Locker { get; set; }
        public DbSet<LocationDetails> LocationDetails { get; set; }
        
        public DbSet<ActionType> ActionType { get; set; }
        
        public DbSet<Part> Part { get; set; }
        public DbSet<Tool> Tool { get; set; }
        public DbSet<Tooling_Movement_Log> Tooling_Movement_Log { get; set; }
        public DbSet<ToolPart> ToolPart { get; set; }

    }
}
