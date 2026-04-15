using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Itransition_Task4.Data;
using Itransition_Task4.Models;
using Itransition_Task4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Itransition_Task4.Controllers;

public class AuthController(IUserService userService, IJwtService jwtService, IUserRepository userRepository) : Controller
{
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult>Login([FromBody] LoginViewModel model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        
        var allUsers = await userRepository.GetAllAsync();
        var user = allUsers.FirstOrDefault(u => u.Email == model.Email);
        
        if (user == null || !PasswordHasher.VerifyPassword(model.Password, user.HashedPassword))
            return Unauthorized("Wrong email or password");
        
        if (user.Status == Status.Blocked)
            return Forbid("Account is blocked");
        
        user.LastLoginTime = DateTime.UtcNow;
        await userRepository.UpdateRangeAsync([user]);
        
        return Ok(new { token = jwtService.GenerateJwtToken(user) });
    }
    
    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        if (model.Password != model.ConfirmPassword)
            return BadRequest("Passwords do not match");
        
        var allUsers = await userRepository.GetAllAsync();
        if (allUsers.Any(u => u.Email == model.Email))
            return BadRequest("Email is already registered");
        
        var user = new User
        {
            Name = model.Name,
            Email = model.Email,
            HashedPassword = PasswordHasher.HashPassword(model.Password),
            Status = Status.Unverified,
            RegistrationDate = DateTime.UtcNow
        };

        await userRepository.AddAsync(user);
        
        return Ok();
    }
}