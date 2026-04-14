namespace Itransition_Task4.Models;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string HashedPassword { get; set; }
    public DateTime LastLoginTime { get; set; } = DateTime.UtcNow;
    public Status Statuses { get; set; } = Status.Unverified;
}

public enum Status
{
    Unverified,
    Active,
    Blocked
}