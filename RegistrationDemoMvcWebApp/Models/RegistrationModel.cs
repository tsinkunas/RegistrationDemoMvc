using System.ComponentModel.DataAnnotations;

namespace RegistrationDemoMvcWebApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please enter your name!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "The name must be between 2 and 30 characters long!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "The name must be in Latin characters, and begin with a capital letter!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age!")]
        [Range(18, 100, ErrorMessage = "The age should be in 18 to 100 range!")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please enter your email!")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
