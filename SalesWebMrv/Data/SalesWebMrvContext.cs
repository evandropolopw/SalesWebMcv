using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMrv.Models;

namespace SalesWebMrv.Data
{
    public class SalesWebMrvContext : DbContext
    {
        public SalesWebMrvContext (DbContextOptions<SalesWebMrvContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMrv.Models.Department> Department { get; set; }
    }
}
