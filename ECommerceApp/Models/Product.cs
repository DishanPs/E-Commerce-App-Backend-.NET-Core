namespace ECommerceApp.Models
{
    public class Product
    {
        public int productID { get; set; }

        public string productName { get; set; }

        public string productCategory { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }

        public string imageUrl { get; set; }
    }
}
