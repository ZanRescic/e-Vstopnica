using Microsoft.AspNetCore.Identity;

namespace e_Vstopnice.Models;

public class User : IdentityUser
{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Type { get; set; }
}
