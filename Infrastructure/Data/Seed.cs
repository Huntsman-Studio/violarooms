using System.Text.Json;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class Seed
{
    public static async Task SeedUsers(UserManager<User> userManager)
    {
        if (await userManager.Users.AnyAsync()) return;

        var userData = await System.IO.File.ReadAllTextAsync("defaultUser.json");
        var users = JsonSerializer.Deserialize<List<User>>(userData);
        
        if (users is null) return;

        foreach (var user in users)
        {
            user.UserName = user.Email.ToLower();
            user.Email = user.Email.ToLower();

            await userManager.CreateAsync(user, "12345678");

            // await userManager.AddToRoleAsync(user, "Admin");
        }
    }
}
