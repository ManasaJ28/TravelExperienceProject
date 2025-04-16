using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DomainLayer.Entities;

namespace Travel.InfrastructureLayer
{
    public class TravelDBContext : DbContext
    {
        public TravelDBContext(DbContextOptions<TravelDBContext> options) : base(options) { }

            public DbSet<Trip> Trips { get; set; }
            
            public DbSet<Activity> Activities { get; set; }
        
    }
}
