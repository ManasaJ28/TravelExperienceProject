using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DomainLayer;
using Travel.DomainLayer.Entities;

namespace Travel.InfrastructureLayer.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly TravelDBContext _dbcontext;
        public TripRepository(TravelDBContext dbContext) { 
            _dbcontext = dbContext; 
        }

        public  async Task<Trip> AddTripasync(Trip trip) {

            var result = await _dbcontext.Trips.AddAsync(trip);
            await _dbcontext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
