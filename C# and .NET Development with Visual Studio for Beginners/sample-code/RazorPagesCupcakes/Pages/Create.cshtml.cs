using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesCupcakes.Data;
using RazorPagesCupcakes.Models;

namespace RazorPagesCupcakes.Pages
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCupcakes.Data.RazorPagesCupcakesContext _context;

        public CreateModel(RazorPagesCupcakes.Data.RazorPagesCupcakesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cupcakes Cupcakes { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cupcakes.Add(Cupcakes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
