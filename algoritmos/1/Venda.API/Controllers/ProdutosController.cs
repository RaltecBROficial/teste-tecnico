using Microsoft.AspNetCore.Mvc;
using SistemaComercial.API.DataTransferObjects.Requests.Produto;
using SistemaComercial.API.DataTransferObjects.Responses.Produto;
using SistemaComercial.API.Interfaces.Services;

namespace SistemaComercial.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public sealed class ProdutosController : ControllerBase
{
    private readonly IProdutoService _produtoService;

	public ProdutosController(IProdutoService produtoService)
	{
		_produtoService = produtoService;
	}

	[HttpPost("add-produto")]
	public async Task AddAsync([FromBody] ProdutoRequest produtoRequest) =>
		await _produtoService.AddAsync(produtoRequest);

	[HttpGet("get-all-produtos")]
	public async Task<List<ProdutoResponse>> GetAllAsync() =>
		await _produtoService.GetAllAsync();
}
