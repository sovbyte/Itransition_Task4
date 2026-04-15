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

public class AuthController(IUserService userService, IJwtService jwtService, IUserRepository userRepository, IEmailService emailService) : Controller
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
        
        var token = Guid.NewGuid().ToString();
        
        var user = new User
        {
            Name = model.Name,
            Email = model.Email,
            HashedPassword = PasswordHasher.HashPassword(model.Password),
            Status = Status.Unverified,
            RegistrationDate = DateTime.UtcNow
        };

        await userRepository.AddAsync(user);

        var confirmUrl = $"http://localhost:5121/confirm-email?token={token}";
        
        await emailService.SendEmailAsync(user.Email, "Confirm your account",
            $"Please confirm your registration by <a href='{confirmUrl}'>clicking here</a>.");

        return Ok("User registered. Please check your email.");
    }
    
    [HttpGet("confirm-email")]
    [AllowAnonymous]
    public async Task<IActionResult> ConfirmEmail([FromQuery] string token)
    {
        if (string.IsNullOrEmpty(token)) return BadRequest("Token is missing");

        var allUsers = await userRepository.GetAllAsync();
        var user = allUsers.FirstOrDefault(u => u.ConfirmationToken == token);

        if (user == null) 
            return BadRequest("Invalid or expired token");

        user.Status = Status.Active;
        user.ConfirmationToken = null; 

        await userRepository.UpdateRangeAsync([user]);

        return Content("Success! Your email is confirmed. Now you can log in.");
    }
    
    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword([FromBody] string email)
    {
        var user = await userRepository.GetByEmailAsync(email);
        if (user == null) return Ok();

        var token = Guid.NewGuid().ToString();
        user.ResetToken = token; 
        await userRepository.UpdateRangeAsync([user]);

        var resetUrl = $"http://localhost:5121/reset-password?token={token}";
        await emailService.SendEmailAsync(user.Email, "Reset Password", 
            $"Click <a href='{resetUrl}'>here</a> to reset your password.");

        return Ok("Reset link sent to your email.");
    }
}