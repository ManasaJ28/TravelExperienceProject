using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DomainLayer.Entities;

namespace Travel.DomainLayer
{
    public interface ITripRepository
    {
        public Task<Trip> AddTripasync(Trip trip);

    }
}
