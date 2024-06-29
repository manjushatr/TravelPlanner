using TravelPlanner.Application.Interfaces;
using TravelPlanner.Domain.Models;
using TravelPlanner.Infrastructure.Data;


namespace TravelPlanner.Application.Services
{
    public class DestinationService:IDestinationService
    {
        private readonly DestinationRepository _repository;

        public DestinationService(DestinationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Destination>> GetDestinationsAsync(string preference)
        {
            // For simplicity, using dummy data
            return await _repository.GetDestinationsAsync(preference);
        }
    }
}
