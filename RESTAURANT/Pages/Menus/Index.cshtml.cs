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
    public class IndexModel : PageModel
    {
        private readonly RESTAURANT.Data.RESTAURANTContext _context;

        public IndexModel(RESTAURANT.Data.RESTAURANTContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Menu != null)
            {
                Menu = await _context.Menu.ToListAsync();
            }
        }
    }
}
