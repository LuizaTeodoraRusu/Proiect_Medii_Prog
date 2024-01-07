using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
namespace RESTAURANT.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [BindProperty]
        public Location Location { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

    }
}
