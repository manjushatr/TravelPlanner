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
    public class ActivityService:IActivityService
    {
        private readonly ActivityRepository _repository;

        public ActivityService(ActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Activity>> GetActivitiesAsync(string destination)
        {
            // For simplicity, using dummy data
            return await _repository.GetActivitiesAsync(destination);
        }
    }
}
