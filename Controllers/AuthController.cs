using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Itransition_Task4.Data;
using Itransition_Task4.Models;
using Itransition_Task4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Itransition_Task4.Controllers;

[ApiController]
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
        {
            Console.WriteLine("User not found in DB");
            return Unauthorized("Wrong email or password");
        }
        
        if (user.Status == Status.Blocked)
            return Forbid("Account is blocked");
        
        user.LastLoginTime = DateTime.UtcNow;
        await userRepository.UpdateRangeAsync([user]);
        
        return Ok(new { token = jwtService.GenerateJwtToken(user) });
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
    {
        try 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var allUsers = await userRepository.GetAllAsync();
            if (allUsers.Any(u => u.Email == model.Email)) 
                return BadRequest("This email is already in the database");

            var token = Guid.NewGuid().ToString();
            var user = new User {
                Name = model.Name,
                Email = model.Email,
                HashedPassword = PasswordHasher.HashPassword(model.Password),
                Status = Status.Unverified,
                ConfirmationToken = token
            };

            await userRepository.AddAsync(user);

            var confirmUrl = $"{Request.Scheme}://{Request.Host}/confirm-email?token={token}";
            await emailService.SendEmailAsync(user.Email, "Confirm", $"Link: {confirmUrl}");

            return Ok("Success! Check email.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при регистрации: {ex.Message}");
            return StatusCode(500, ex.Message);
        }
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

        var resetUrl = $"{Request.Scheme}://{Request.Host}/reset-password?token={token}";
        await emailService.SendEmailAsync(user.Email, "Reset Password", 
            $"Click <a href='{resetUrl}'>here</a> to reset your password.");

        return Ok("Reset link sent to your email.");
    }
    
    [HttpGet("Auth/Login")]
    [AllowAnonymous]
    public IActionResult LoginView()
    {
        return View("Login");
    }

    [HttpGet("Auth/Register")]
    [AllowAnonymous]
    public IActionResult RegisterView()
    {
        return View("Register");
    }
    
    [HttpGet("reset-password")]
    [AllowAnonymous]
    public IActionResult ResetPasswordView([FromQuery] string token)
    {
        ViewData["Token"] = token;
        return View("ResetPassword");
    }

    [HttpPost("reset-password-confirm")]
    [AllowAnonymous]
    public async Task<IActionResult> ResetPasswordConfirm([FromBody] ResetPasswordViewModel model)
    {
        var allUsers = await userRepository.GetAllAsync();
        var user = allUsers.FirstOrDefault(u => u.ResetToken == model.Token);

        if (user == null) return BadRequest("Invalid token");

        user.HashedPassword = PasswordHasher.HashPassword(model.NewPassword);
        user.ResetToken = null;
        await userRepository.UpdateRangeAsync([user]);

        return Ok("Password updated successfully");
    }
}