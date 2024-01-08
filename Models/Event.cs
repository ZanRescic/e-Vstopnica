using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_Vstopnice.Models;

public class Event
{
    public int Id { get; set; }
    
    [Required]
    public required string Name { get; set; }
    
    [Required]
    public DateTime Time { get; set; }
    
    [Required]
    public int NumberOfSpots { get; set; }
    
    [ForeignKey("Place"), Required]
    public int PlaceId { get; set; }
}