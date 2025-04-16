using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.ApplicationLayer.DTO
{
    public class TripResponse
    {
        public int TripId { get; set; }
        public string Title { get; set; }
        public decimal TotalCost { get; set; }
        public List<ActivityDto> Activities { get; set; }
    }
}
