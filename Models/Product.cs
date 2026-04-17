namespace MultiLingualEcommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        // These will be populated from Resource files based on Culture
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
