using System.ComponentModel.DataAnnotations;

namespace Itransition_Task4.Models;

public class UserViewModel
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public DateTime? LastLoginTime { get; set; }
    
    public string Status { get; set; } = string.Empty;
}