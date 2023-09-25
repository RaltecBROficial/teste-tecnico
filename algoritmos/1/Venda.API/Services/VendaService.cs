using SistemaComercial.API.DataTransferObjects.Requests.Venda;
using SistemaComercial.API.DataTransferObjects.Responses.Venda;
using SistemaComercial.API.Entities;
using SistemaComercial.API.Interfaces.Mappers;
using SistemaComercial.API.Interfaces.Repositories;
using SistemaComercial.API.Interfaces.Services;
using SistemaComercial.API.Interfaces.Settings.NotificationSettings;

namespace SistemaComercial.API.Services;

public sealed class VendaService : IVendaService
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IVendaRepository _vendaRepository;
    private readonly ICalculoDescontoService _calculoDescontoService;
    private readonly IVendaMapper _vendaMapper;
    private readonly INotificationHandler _notificationHandler;

    public VendaService(IProdutoRepository produtoRepository, IVendaRepository vendaRepository,
                        ICalculoDescontoService calculoDescontoService, IVendaMapper vendaMapper,
                        INotificationHandler notificationHandler)
    {
        _produtoRepository = produtoRepository;
        _vendaRepository = vendaRepository;
        _calculoDescontoService = calculoDescontoService;
        _vendaMapper = vendaMapper;
        _notificationHandler = notificationHandler;
    }

    public async Task AddAsync(VendaRequest vendaRequest)
    {
        var groupedProductDictionary = vendaRequest.Produtos.GroupBy(v => v.ProdutoId).ToDictionary(g => g.Key, g => g.Count());
        var venda = new Venda()
        {
            Produtos = new List<ProdutoVenda>()
        };

        foreach (var groupedProduct in groupedProductDictionary)
        {
            var codigo = groupedProduct.Key;
            if (!await _produtoRepository.ExistsAsync(codigo))
            {
                _notificationHandler.AddNotification("Not found", $"Product does not exist: {codigo}.");
                return;
            }

            var produto = await _produtoRepository.GetProdutoByCodigoAsync(codigo);
            var quantidade = groupedProduct.Value;
            var desconto = _calculoDescontoService.CalcularDesconto(quantidade);
            var valorProduto = produto.ValorUnitario - (produto.ValorUnitario * desconto / 100);
            var produtoVenda = new ProdutoVenda()
            {
                Desconto = desconto,
                Nome = produto.Nome,
                ValorProduto = valorProduto,
                ValorTotal = valorProduto * quantidade,
                Quantidade = quantidade,
                ProdutoId = produto.Codigo
            };
            venda.Produtos.Add(produtoVenda);
        }
        venda.Data = DateTime.Now;
        venda.ValorTotal = venda.Produtos.Sum(p => p.ValorTotal);

        await _vendaRepository.AddAsync(venda);
    }

    public async Task<List<VendaResponse>> GetAllAsync()
    {
        var vendaList = await _vendaRepository.GetAllAsync();

        var vendaResponseList = new List<VendaResponse>();
        foreach (var venda in vendaList)
        {
            vendaResponseList.Add(_vendaMapper.DomainToResponse(venda));
        }

        return vendaResponseList;
    }
}
