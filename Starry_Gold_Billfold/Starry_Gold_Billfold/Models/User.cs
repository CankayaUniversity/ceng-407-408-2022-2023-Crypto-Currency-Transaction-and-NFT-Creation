using System.ComponentModel.DataAnnotations;

namespace Starry_Gold_Billfold.Models
{
    public class User
    {
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get;set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
