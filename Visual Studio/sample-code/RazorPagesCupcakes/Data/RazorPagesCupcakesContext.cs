using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCupcakes.Models;

namespace RazorPagesCupcakes.Data
{
    public class RazorPagesCupcakesContext : DbContext
    {
        public RazorPagesCupcakesContext (DbContextOptions<RazorPagesCupcakesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCupcakes.Models.Cupcakes> Cupcakes { get; set; } = default!;
    }
}
