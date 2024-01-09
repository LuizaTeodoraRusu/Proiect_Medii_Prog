using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;

namespace RESTAURANT.Data
{
    public class RESTAURANTContext : DbContext
    {
        public RESTAURANTContext (DbContextOptions<RESTAURANTContext> options)
            : base(options)
        {
        }

        public DbSet<RESTAURANT.Models.Location> Location { get; set; } = default!;

        public DbSet<RESTAURANT.Models.Menu>? Menu { get; set; }

        public DbSet<RESTAURANT.Models.Reservation>? Reservation { get; set; }

        public DbSet<RESTAURANT.Models.Client>? Client { get; set; }
    }
}
