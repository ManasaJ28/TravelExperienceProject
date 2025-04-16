using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.ApplicationLayer.DTO;

namespace Travel.ApplicationLayer.Interfaces
{
    public interface ITripService
    {
        public Task<TripResponse> CreateTripasync (TripRequest tripRequest);
    }
}
