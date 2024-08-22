using DemoMvcApp.Models;
using DemoMvcApp.Repositories;
using DemoMvcApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvcApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
