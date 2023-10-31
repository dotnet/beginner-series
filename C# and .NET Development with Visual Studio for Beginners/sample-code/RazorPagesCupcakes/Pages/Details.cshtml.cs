using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCupcakes.Data;
using RazorPagesCupcakes.Models;

namespace RazorPagesCupcakes.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCupcakes.Data.RazorPagesCupcakesContext _context;

        public DetailsModel(RazorPagesCupcakes.Data.RazorPagesCupcakesContext context)
        {
            _context = context;
        }

        public Cupcakes Cupcakes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupcakes = await _context.Cupcakes.FirstOrDefaultAsync(m => m.Id == id);
            if (cupcakes == null)
            {
                return NotFound();
            }
            else
            {
                Cupcakes = cupcakes;
            }
            return Page();
        }
    }
}
