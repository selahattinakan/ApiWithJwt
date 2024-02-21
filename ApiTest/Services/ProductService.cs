using ApiTest.Interfaces;
using System.Text.Json;

namespace ApiTest.Services
{
    public class ProductService : IProductService
    {
        private List<ProductModel> ConvertProductsFromJSON()
        {
            using (StreamReader r = new StreamReader("Data/products.json"))
            {
                string json = r.ReadToEnd();
                Product item = JsonSerializer.Deserialize<Product>(json);
                return item != null ? item.products : new List<ProductModel>();
            }
        }
        public List<ProductModel> GetProducts()
        {
            return ConvertProductsFromJSON();
        }
    }
}
