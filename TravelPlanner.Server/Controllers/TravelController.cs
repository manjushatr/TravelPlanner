using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelPlanner.Application.Interfaces;

namespace TravelPlanner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {

        private readonly IDestinationService _destinationService;
        private readonly IFlightService _flightService;
        private readonly IAccommodationService _accommodationService;
        private readonly IActivityService _activityService;

        public TravelController(
            IDestinationService destinationService,
            IFlightService flightService,
            IAccommodationService accommodationService,
            IActivityService activityService)
        {
            _destinationService = destinationService;
            _flightService = flightService;
            _accommodationService = accommodationService;
            _activityService = activityService;
        }

        [HttpGet("destinations")]
        public async Task<IActionResult> GetDestinations([FromQuery] string preference)
        {
            var destinations = await _destinationService.GetDestinationsAsync(preference);
            return Ok(destinations);
        }

        [HttpGet("flights")]
        public async Task<IActionResult> GetFlights([FromQuery] string destination)
        {
            var flights = await _flightService.GetFlightsAsync(destination);
            return Ok(flights);
        }

        [HttpGet("accommodations")]
        public async Task<IActionResult> GetAccommodations([FromQuery] string destination)
        {
            var accommodations = await _accommodationService.GetAccommodationsAsync(destination);
            return Ok(accommodations);
        }

        [HttpGet("activities")]
        public async Task<IActionResult> GetActivities([FromQuery] string destination)
        {
            var activities = await _activityService.GetActivitiesAsync(destination);
            return Ok(activities);
        }
    }
}
