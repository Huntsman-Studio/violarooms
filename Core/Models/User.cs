using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class User : IdentityUser<int>
{
    public ICollection<UserRoles> UserRoles { get; set; }
}
