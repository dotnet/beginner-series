using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCupcakes.Models;

public class Cupcakes
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }

    // Add ingredients property
    
}