using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Raltec01.Application.Interfaces;
using TesteTecnico.Raltec01.Application.ViewModels;

namespace TesteTecnico.Raltec01.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SaleController : ControllerBase
	{
		private readonly ISaleService _saleService;

		public SaleController(ISaleService saleService)
		{
			_saleService = saleService;
		}

		[HttpPost("add")]
		public async Task<IActionResult> Add(SaleViewModel sale)
		{
			if (!ModelState.IsValid) return BadRequest();
			await _saleService.AddAsync(sale);

			return Ok();
		}
	}
}
