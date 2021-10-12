using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using fooddelivery.foodie;

namespace fooddelivery
{
    public class foodieContext : DbContext
    {
        public foodieContext (DbContextOptions<foodieContext> options)
            : base(options)
        {
        }

        public DbSet<fooddelivery.foodie.newfoodie> newfoodie { get; set; }
    }
}
