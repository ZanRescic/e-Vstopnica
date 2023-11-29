using Microsoft.AspNetCore.Identity;

namespace e_Vstopnice.Models;

public class User : IdentityUser<int>
{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Type { get; set; }
}
