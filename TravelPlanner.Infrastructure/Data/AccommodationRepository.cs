using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlanner.Domain.Models;

namespace TravelPlanner.Infrastructure.Data
{
    public class AccommodationRepository
    {
        public async Task<IEnumerable<Accommodation>> GetAccommodationsAsync(string destination)
        {
            // Dummy data for demonstration
            var accommodations = new List<Accommodation>
            {
                new Accommodation { Name = "Hotel A", Address = "Address A", PricePerNight = 100, Rating = "4.5" },
                new Accommodation { Name = "Hotel B", Address = "Address B", PricePerNight = 150, Rating = "4.0" }
            };

            return await Task.FromResult(accommodations);
        }
    }
}
