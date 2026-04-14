using System.ComponentModel.DataAnnotations;

namespace Itransition_Task4.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "Enter Email")]
    [EmailAddress(ErrorMessage = "Incorrect Email format")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}