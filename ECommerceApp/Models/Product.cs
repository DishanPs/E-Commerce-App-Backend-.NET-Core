using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Product
    {
        public int productID { get; set; }

        [Required]
        public string productName { get; set; }

        [Required]
        public string productCategory { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal price { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int quantity { get; set; }

        [Url]
        public string imageUrl { get; set; }
    }
}
