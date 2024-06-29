using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlanner.Domain.Models;

namespace TravelPlanner.Application.Interfaces
{
    public interface IDestinationService
    {
        Task<IEnumerable<Destination>> GetDestinationsAsync(string preference);
    }
}
