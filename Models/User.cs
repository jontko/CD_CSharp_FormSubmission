using System.ComponentModel.DataAnnotations;
 
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string First { get; set; }
 
        [Required]
        [MinLength(3)]
        public string Last { get; set; }
 
        [Required]
        [Range(0, 120)]
        public int Age { get; set; }
 
        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
