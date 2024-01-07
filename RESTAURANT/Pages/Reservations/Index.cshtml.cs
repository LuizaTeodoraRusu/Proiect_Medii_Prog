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
    public class IndexModel : PageModel
    {
        private readonly RESTAURANT.Data.RESTAURANTContext _context;

        public IndexModel(RESTAURANT.Data.RESTAURANTContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Reservation != null)
            {
                Reservation = await _context.Reservation
                .Include(r => r.Location).ToListAsync();
            }
        }
    }
}
