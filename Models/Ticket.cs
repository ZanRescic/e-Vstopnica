using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace e_Vstopnice.Models;

public class Ticket
{
    [ForeignKey("User"), Required]
    public int UserId { get; set; }
    
    [ForeignKey("Event"), Required]
    public int EventId { get; set; }
}