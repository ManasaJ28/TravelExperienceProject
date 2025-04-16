using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DomainLayer.Entities
{
    public class Trip
    {
        public int TripId { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }
        public List<Activity> ActivityList { get; set; } = new List<Activity>();

    }
}
