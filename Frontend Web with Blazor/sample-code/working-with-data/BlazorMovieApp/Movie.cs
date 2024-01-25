using System.ComponentModel.DataAnnotations;

namespace BlazorMovieApp;

public class Movie
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
    
    public string? Genre { get; set; }

    [Range(0, 100)]
    public decimal Price { get; set; }
}