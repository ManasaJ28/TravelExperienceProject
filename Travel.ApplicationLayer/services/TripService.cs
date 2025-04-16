using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.ApplicationLayer.DTO;
using Travel.ApplicationLayer.Interfaces;
using Travel.DomainLayer;
using Travel.DomainLayer.Entities;

namespace Travel.ApplicationLayer.services
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;
        public TripService(ITripRepository tripRepository) { 
        
            _tripRepository = tripRepository;
        }

        public async Task<TripResponse> CreateTripasync(TripRequest tripRequest)
        {
            if (tripRequest.StartDate > tripRequest.EndDate)
                throw new ArgumentException("EndDate cannot be before than StartDate");

            decimal totalCost = tripRequest.Activities.Sum(x => x.Cost);

            var trip = new Trip
            {
                Title = tripRequest.Title,
                UserId = tripRequest.UserId,
                StartDate = tripRequest.StartDate,
                EndDate = tripRequest.EndDate,
                TotalCost = totalCost,
                ActivityList = tripRequest.Activities.Select(a => new Activity
                {
                    DestivationId = a.DestivationId,
                    Cost = a.Cost,
                    Duration = a.Duration,
                }).ToList()

            };

            var createdTrip = await _tripRepository.AddTripasync(trip);


            var response = new TripResponse
            {
                TripId = createdTrip.TripId,
                Title = createdTrip.Title,
                TotalCost = createdTrip.TotalCost,
                Activities = createdTrip.ActivityList.Select(a => new ActivityDto
                {
                    DestivationId = a.DestivationId,
                    Cost = a.Cost,
                    Duration = a.Duration,
                }).ToList()
            };

            return response;
        }
    }
}
