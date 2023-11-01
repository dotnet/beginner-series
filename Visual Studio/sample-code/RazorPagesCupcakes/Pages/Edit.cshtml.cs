using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesCupcakes.Data;
using RazorPagesCupcakes.Models;

namespace RazorPagesCupcakes.Pages
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesCupcakes.Data.RazorPagesCupcakesContext _context;

        public EditModel(RazorPagesCupcakes.Data.RazorPagesCupcakesContext context)
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

            var cupcakes =  await _context.Cupcakes.FirstOrDefaultAsync(m => m.Id == id);
            if (cupcakes == null)
            {
                return NotFound();
            }
            Cupcakes = cupcakes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cupcakes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CupcakesExists(Cupcakes.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CupcakesExists(int id)
        {
            return _context.Cupcakes.Any(e => e.Id == id);
        }
    }
}
