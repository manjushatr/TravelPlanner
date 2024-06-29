using TravelPlanner.Domain.Models;

namespace TravelPlanner.Infrastructure.Data
{
    public class DestinationRepository
    {
        public async Task<IEnumerable<Destination>> GetDestinationsAsync(string preference)
        {
            // Dummy data for demonstration
            var destinations = new List<Destination>
            {
                new Destination { Name = "Paris", Description = "City of Light", Country = "France" },
                new Destination { Name = "New York", Description = "The Big Apple", Country = "USA" },
                new Destination { Name = "Tokyo", Description = "Land of the Rising Sun", Country = "Japan" }
            };

            return await Task.FromResult(destinations);
        }
    }
}
