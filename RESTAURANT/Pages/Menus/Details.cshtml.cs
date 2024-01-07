using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Data;
using RESTAURANT.Models;

namespace RESTAURANT.Pages.Menus
{
    public class DetailsModel : PageModel
    {
        private readonly RESTAURANT.Data.RESTAURANTContext _context;

        public DetailsModel(RESTAURANT.Data.RESTAURANTContext context)
        {
            _context = context;
        }

      public Menu Menu { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Menu == null)
            {
                return NotFound();
            }

            var menu = await _context.Menu.FirstOrDefaultAsync(m => m.MenuId == id);
            if (menu == null)
            {
                return NotFound();
            }
            else 
            {
                Menu = menu;
            }
            return Page();
        }
    }
}
