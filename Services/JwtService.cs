using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Itransition_Task4.Models;
using Microsoft.IdentityModel.Tokens;

namespace Itransition_Task4.Services;

public interface IJwtService
{
    string GenerateJwtToken(User user);
}

public class JwtService :  IJwtService
{
    public string GenerateJwtToken(User user)
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
};