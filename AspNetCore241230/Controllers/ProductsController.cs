using Microsoft.AspNetCore.Mvc;

namespace AspNetCore241230.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll ()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Product1", Price = 10 },
                new { Id = 2, Name = "Product2", Price = 20 }
            };
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById (int id)
        {
            var product = new { Id = id, Name = $"Product{id}", Price = id * 10 };
            return Ok(product);
        }
    }
}
