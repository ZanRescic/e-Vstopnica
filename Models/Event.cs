using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_Vstopnice.Models;

public class Event
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public DateTime Time { get; set; }
    
    [ForeignKey("Place"), Required]
    public DateTime PlaceId { get; set; }
}