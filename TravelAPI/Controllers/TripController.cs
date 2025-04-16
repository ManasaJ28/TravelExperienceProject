using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travel.ApplicationLayer.DTO;
using Travel.ApplicationLayer.Interfaces;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ITripService _service;
        private readonly ILogger<TripController> _logger;
        public TripController(ITripService service,ILogger<TripController> logger) { 
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrip ([FromBody] TripRequest request)
        {
            try
            {
                var response = await _service.CreateTripasync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating trip for user {UserId}", request.UserId);

                return StatusCode(500, new
                {
                    Message = ex.Message.ToString()
                });
            }
        }
    }
}
