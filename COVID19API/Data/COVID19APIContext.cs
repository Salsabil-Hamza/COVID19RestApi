using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COVID19API.Models
{
    public class COVID19APIContext : DbContext
    {
        public COVID19APIContext (DbContextOptions<COVID19APIContext> options)
            : base(options)
        {
        }

        public DbSet<COVID19API.Models.COVID19> COVID19 { get; set; }
    }
}
