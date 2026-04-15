using System.ComponentModel.DataAnnotations;

namespace Itransition_Task4.Models;

public class User
{
    public int Id { get; set; }
    
    public required string Name { get; set; }
    
    public required string Email { get; set; }
    
    public required string HashedPassword { get; set; }
    
    public DateTime? LastLoginTime { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; } = Status.Unverified;
}

public enum Status
{
    Unverified,
    Active,
    Blocked
}