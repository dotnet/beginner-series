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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCupcakes.Data.RazorPagesCupcakesContext _context;

        public IndexModel(RazorPagesCupcakes.Data.RazorPagesCupcakesContext context)
        {
            _context = context;
        }

        public IList<Cupcakes> Cupcakes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cupcakes = await _context.Cupcakes.ToListAsync();
        }
    }
}
