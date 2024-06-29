using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlanner.Domain.Models;

namespace TravelPlanner.Infrastructure.Data
{
    public class ActivityRepository
    {
        public async Task<IEnumerable<Activity>> GetActivitiesAsync(string destination)
        {
            // Dummy data for demonstration
            var activities = new List<Activity>
            {
                new Activity { Name = "Activity A", Description = "Description A", Price = 50 },
                new Activity { Name = "Activity B", Description = "Description B", Price = 75 }
            };

            return await Task.FromResult(activities);
        }
    }
}
