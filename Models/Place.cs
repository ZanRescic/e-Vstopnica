using System.ComponentModel.DataAnnotations;

namespace e_Vstopnice.Models;

public class Place
{
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Address { get; set; }
    
    [Required]
    public int NumberOfSpots { get; set; }
}