using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Itransition_Task4.Models;
using Itransition_Task4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Itransition_Task4.Controllers;

public class AuthController(ApplicationContext db) : Controller
{
    [HttpPost]
    [AllowAnonymous]
    public ActionResult Login([FromBody] LoginViewModel model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        
        var user = db.Users.FirstOrDefault(u => u.Email == model.Email);
        
        if (user == null)
            return Unauthorized("Wrong email or password");
        
        var isPasswordValid = PasswordHasher.VerifyPassword(model.Password, user.HashedPassword);
        
        if (!isPasswordValid)
            return Unauthorized("Wrong email or password");
        
        if (user.Statuses == Status.Blocked)
            return Forbid("Account is blocked");
        
        user.LastLoginTime = DateTime.UtcNow;
        db.SaveChanges();
        
        return Ok(new { token = GenerateJwtToken(user) });
    }
    
    [HttpPost]
    [AllowAnonymous]
    public ActionResult Register()
    {
        return Ok();
    }
    
    private static string GenerateJwtToken(User user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email ?? ""),
            new Claim(ClaimTypes.Name, user.Name ?? "")
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY")!)
        );

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: Environment.GetEnvironmentVariable("JWT_ISSUER"),
            audience: Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
            claims: claims,

            expires: DateTime.UtcNow.AddMinutes(
                double.TryParse(Environment.GetEnvironmentVariable("JWT_EXPIRY_MINUTES"), out var exp) ? exp : 60
            ),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}