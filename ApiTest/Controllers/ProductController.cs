using ApiTest.Interfaces;
using ApiTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("GetProducts")]
        [AllowAnonymous]
        public List<ProductModel> GetProducts()
        {
            return productService.GetProducts();
        }

        [HttpGet("GetProduct")]
        [Authorize]
        public ProductModel? GetProduct(int id)
        {
            return productService.GetProducts().FirstOrDefault(x => x.id == id);
        }
    }
}
