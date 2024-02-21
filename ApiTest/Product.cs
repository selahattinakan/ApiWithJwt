namespace ApiTest
{
    public class Product
    {
        public List<ProductModel> products { get; set; } //örnek kullanılan jsondan dolayı modelleme bu şekilde yapıldı
    }
    public class ProductModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal discountPercentage { get; set; }
        public decimal rating { get; set; }
        public int stock { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string thumbnail { get; set; }
        public List<string> images { get; set; }
    }
}
