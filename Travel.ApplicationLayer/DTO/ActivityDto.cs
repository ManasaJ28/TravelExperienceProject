using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.ApplicationLayer.DTO
{
    public class ActivityDto
    {
        [Required(ErrorMessage = "DestinationId is required.")]
        public int DestivationId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Duration must be at least 1.")]
        public int Duration { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be a positive number.")]
        public decimal Cost { get; set; }
    }
}
