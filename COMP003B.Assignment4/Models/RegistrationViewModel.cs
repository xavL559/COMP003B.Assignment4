using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class RegistrationViewModel
    {
        [Key]
        [Required(ErrorMessage = "Please enter a valid Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid Phone Number")]
        public long Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid Home Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        
    }
}
