using Microsoft.AspNetCore.Mvc;
using CommercialSystem.Server.Repositories;
using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;
using CommercialSystem.Server.Mappings;

namespace CommercialSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProductsAsync()
        {
            IEnumerable<PRD_PRODUCT> lstProducts = await _productRepository.GetAllProductsAsync();
            return Ok(lstProducts.ConvertToDto());
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProductAsync(Product product)
        {
            PRD_PRODUCT newProduct = await _productRepository.AddProductAsync(new PRD_PRODUCT
            {
                Name = product.Name,
                PriceUnit = Convert.ToInt32(product.UnitPrice)
            });

            return Ok(newProduct.ConvertToDto());
        }

        [HttpDelete]
        [Route("{productId:int}")]
        public async Task<ActionResult> RemoveProduct(int productId)
        {
            PRD_PRODUCT? prdProduct = await _productRepository.RemoveProductAsync(productId);

            if(prdProduct is not null)
                return Ok(prdProduct.ConvertToDto());
            else
                return NotFound();
        }
    }
}
