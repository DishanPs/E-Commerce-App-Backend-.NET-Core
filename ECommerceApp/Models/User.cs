using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string fullName { get; set; }

        [Required]
        public string contactNo { get; set; }

        [Required]
        [MinLength(8)]
        public string password { get; set; }
    }
}
