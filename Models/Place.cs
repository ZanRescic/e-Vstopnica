using System.ComponentModel.DataAnnotations;

namespace e_Vstopnice.Models;

public class Place
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Address { get; set; }
}