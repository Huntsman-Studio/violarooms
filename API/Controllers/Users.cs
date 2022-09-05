using API.DTOs;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class Users : BaseApiController
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly ITokenService _tokenService;
    public readonly IConfiguration _config;
    public Users(UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService, IConfiguration config)
    {
        _config = config;
        _tokenService = tokenService;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    // [Authorize]
    // RegisterUser
    [HttpPost("Register")]
    public async Task<ActionResult<UserDto>> Register(RegisterLoginDto val)
    {
        if (await UserExists(val.Email)) return BadRequest("User Already Exists");

        var user = new User
        {
            UserName = val.Email.ToLower(),
            Email = val.Email.ToLower()
        };

        var result = await _userManager.CreateAsync(user, val.Password);

        if(!result.Succeeded) return BadRequest(result.Errors);

        var roleResult = await _userManager.AddToRoleAsync(user, val.Role);

        if (!roleResult.Succeeded) return BadRequest(result.Errors);

        return new UserDto
        {
            Email = user.Email,
            Token = _tokenService.CreateToken(user)
        };
    }

    // Login
    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> Login(RegisterLoginDto val)
    {
        return Ok();
    }

    // check if user exists
    private async Task<bool> UserExists(string username)
    {
        return await _userManager.Users.AnyAsync(u => u.UserName == username.ToLower());
    }
}
