using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace e_Vstopnice.Models;

public class Ticket
{
    public int Id { get; set; }
    
    [ForeignKey("User"), Required]
    public ApplicationUser? UserId { get; set; }
    
    [ForeignKey("Event"), Required]
    public int? EventId { get; set; }

    public int StVstopnic { get; set; }
    
}

