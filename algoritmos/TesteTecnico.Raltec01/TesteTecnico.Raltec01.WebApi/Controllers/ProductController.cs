using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Raltec01.Application.Interfaces;
using TesteTecnico.Raltec01.Application.ViewModels;

namespace TesteTecnico.Raltec01.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<ProductViewModel>>> Get()
		{
			var result = await _productService.GetAllAsync();
			return Ok(result);
		}

		[HttpGet("{id:guid}")]
		public async Task<ActionResult<ProductViewModel>> Get(Guid id)
		{
			return Ok(await _productService.GetByIdAsync(id));
		}

		[HttpPost]
		public async Task<IActionResult> Add(ProductViewModel product)
		{
			await _productService.AddAsync(product);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> Update(ProductViewModel product)
		{
			await _productService.UpdateAsync(product);
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> Remove(ProductViewModel product)
		{
			await _productService.RemoveAsync(product);
			return Ok();
		}
	}
}
