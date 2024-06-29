using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlanner.Application.Interfaces;
using TravelPlanner.Domain.Models;
using TravelPlanner.Infrastructure.Data;

namespace TravelPlanner.Application.Services
{
   public class FlightService:IFlightService
    {
        private readonly FlightRepository _repository;

        public FlightService(FlightRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync(string destination)
        {
            // For simplicity, using dummy data
            return await _repository.GetFlightsAsync(destination);
        }
    }
}
