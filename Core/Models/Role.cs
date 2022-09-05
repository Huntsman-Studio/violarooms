using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class Role : IdentityRole<int>
{
    public ICollection<UserRoles> UserRoles { get; set; }
}
