using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        public string password { get; set; }
    }
}
