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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesCupcakes.Data.RazorPagesCupcakesContext _context;

        public DeleteModel(RazorPagesCupcakes.Data.RazorPagesCupcakesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupcakes = await _context.Cupcakes.FindAsync(id);
            if (cupcakes != null)
            {
                Cupcakes = cupcakes;
                _context.Cupcakes.Remove(Cupcakes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
