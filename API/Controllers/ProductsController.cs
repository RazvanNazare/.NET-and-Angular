using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]
        public string GetProducts()
        {
            return "This will be a list of produc";
        }
        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "single product";
        }
    }
}