using Microsoft.AspNetCore.Mvc;
using SistemaComercial.API.DataTransferObjects.Requests.Venda;
using SistemaComercial.API.DataTransferObjects.Responses.Venda;
using SistemaComercial.API.Interfaces.Services;

namespace SistemaComercial.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public sealed class VendaController : ControllerBase
{
    private readonly IVendaService _vendaService;

	public VendaController(IVendaService vendaService)
	{
		_vendaService = vendaService;
	}

	[HttpPost("add-venda")]
	public async Task AddAsync([FromBody] VendaRequest vendaRequest) =>
		await _vendaService.AddAsync(vendaRequest);

	[HttpGet("get-all-vendas")]
	public async Task<List<VendaResponse>> GetAllAsync() =>
		await _vendaService.GetAllAsync();
}
