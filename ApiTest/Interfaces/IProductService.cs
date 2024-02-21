using ApiTest.Models;

namespace ApiTest.Interfaces
{
    public interface IProductService
    {
        public List<ProductModel> GetProducts();
    }
}
