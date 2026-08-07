using Microsoft.AspNetCore.Mvc;
using MyTradeAPI.Services.UserService;

namespace MyTradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("ProductList")]
        public IActionResult ProductList()
        {
            var products = _productService.getAllProducts();
            return Ok(products);
        }



    }
}
