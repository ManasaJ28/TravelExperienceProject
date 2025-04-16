using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DomainLayer.Entities
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int DestivationId { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }

        [ForeignKey("Trip")]
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
