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

        public DbSet<User>Users{ get; set; }

    }
}
