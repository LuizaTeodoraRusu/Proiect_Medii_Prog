using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Data;
using RESTAURANT.Models;

namespace RESTAURANT.Pages.Reservations
{
    public class DetailsModel : PageModel
    {
        private readonly RESTAURANT.Data.RESTAURANTContext _context;

        public DetailsModel(RESTAURANT.Data.RESTAURANTContext context)
        {
            _context = context;
        }

      public Reservation Reservation { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FirstOrDefaultAsync(m => m.ReservationId == id);
            if (reservation == null)
            {
                return NotFound();
            }
            else 
            {
                Reservation = reservation;
            }
            return Page();
        }
    }
}
