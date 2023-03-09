using System.ComponentModel.DataAnnotations;

namespace RMS.Api.Core.DTO
{
    public class UserDto
    {
        [MinLength(6)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [RegularExpression(@"[a-z0-9]+@qualminds.com",
         ErrorMessage = "Invalid Email Address")]
        public string UserName { get; set; }
        [MinLength(8)]
        [MaxLength(10)]
        public string Password { get; set; }    
    }
}
