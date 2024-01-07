using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Data;
using RESTAURANT.Models;

namespace RESTAURANT.Pages.Locations
{
    public class DetailsModel : PageModel
    {
        private readonly RESTAURANT.Data.RESTAURANTContext _context;

        public DetailsModel(RESTAURANT.Data.RESTAURANTContext context)
        {
            _context = context;
        }

      public Location Location { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Location == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FirstOrDefaultAsync(m => m.LocationId == id);
            if (location == null)
            {
                return NotFound();
            }
            else 
            {
                Location = location;
            }
            return Page();
        }
    }
}
