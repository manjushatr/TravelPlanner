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
    public class AccommodationService:IAccommodationService
    {
        private readonly AccommodationRepository _repository;

        public AccommodationService(AccommodationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Accommodation>> GetAccommodationsAsync(string destination)
        {
            // For simplicity, using dummy data
            return await _repository.GetAccommodationsAsync(destination);
        }
    }
}
