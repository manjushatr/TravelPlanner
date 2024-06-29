using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlanner.Domain.Models;

namespace TravelPlanner.Infrastructure.Data
{
    public class FlightRepository
    {
        public async Task<IEnumerable<Flight>> GetFlightsAsync(string destination)
        {
            // Dummy data for demonstration
            var flights = new List<Flight>
            {
                new Flight { Airline = "Airline A", FlightNumber = "AA123", Departure = "City X", Arrival = "City Y", Price = 200 },
                new Flight { Airline = "Airline B", FlightNumber = "BB456", Departure = "City X", Arrival = "City Y", Price = 250 }
            };

            return await Task.FromResult(flights);
        }
    }
}
