using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner.Domain.Models
{
    public class Accommodation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal PricePerNight { get; set; }
        public string Rating { get; set; }
    }
}
