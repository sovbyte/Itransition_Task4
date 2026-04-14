using System.ComponentModel.DataAnnotations;

namespace Itransition_Task4.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Enter Name")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Enter Email")]
    [EmailAddress(ErrorMessage = "Incorrect Email format")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Enter Confirm password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = string.Empty;
}