using System.ComponentModel.DataAnnotations;
using WebbApp.Filters;

namespace WebbApp.ViewModels;

public class SignUpViewModel
{
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "You must enter a first name")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "You must enter a last name")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your e-mail addresss")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must enter your e-mail address")]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "You must enter a valid password")]
    public string Password { get; set; } = null!;


    [Required(ErrorMessage = "Password must confirmed")]
    [Display(Name = "Confirm password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;


    [CheckboxRequired(ErrorMessage = "You must accept the terms and conditions")]
    [Display(Name = "I agree to the Terms & Conditions.", Prompt = "Terms and Conditions")]
    public bool TermsAndConditions { get; set; }   

}
