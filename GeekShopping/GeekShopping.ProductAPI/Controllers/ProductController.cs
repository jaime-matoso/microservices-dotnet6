using GeekShopping.ProductAPI.Data.ValueObject;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<IActionResult> FindAllAsync()
        {
            var products = await _repository.FindAllAsync();
            
            if (products == null) 
                return NotFound();
            

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindByIdAsync(long id)
        {
            var product = await _repository.FindByIdAsync(id);
            
            if (product == null)
                return Ok();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateByIdAsync(ProductVO productVO)
        {
            if (productVO == null)
                return BadRequest();
            
            var product = await _repository.CreateByIdAsync(productVO);
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateByIdAsync(ProductVO productVO)
        {
            if (productVO == null)
                return BadRequest();

            var product = await _repository.UpdateByIdAsync(productVO);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(long id)
        {
            var status = await _repository.DeleteByIdAsync(id);
            if (!status)
                return BadRequest();

            return Ok(status);
        }
    }
}
