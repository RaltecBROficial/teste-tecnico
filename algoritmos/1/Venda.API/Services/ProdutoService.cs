using SistemaComercial.API.DataTransferObjects.Requests.Produto;
using SistemaComercial.API.DataTransferObjects.Responses.Produto;
using SistemaComercial.API.Interfaces.Mappers;
using SistemaComercial.API.Interfaces.Repositories;
using SistemaComercial.API.Interfaces.Services;
using SistemaComercial.API.Interfaces.Settings.NotificationSettings;
using SistemaComercial.API.Interfaces.Settings.ValidationSettings;

namespace SistemaComercial.API.Services;

public sealed class ProdutoService : IProdutoService
{
    private readonly IProdutoMapper _produtoMapper;
    private readonly IProdutoValidation _produtoValidation;
    private readonly INotificationHandler _notificationHandler;
    private readonly IProdutoRepository _produtoRepository;
	public ProdutoService(IProdutoMapper produtoMapper, IProdutoValidation produtoValidation,
                          INotificationHandler notificationHandler, IProdutoRepository produtoRepository)
	{
		_produtoMapper = produtoMapper;
        _produtoValidation = produtoValidation;
        _notificationHandler = notificationHandler;
        _produtoRepository = produtoRepository;
	}

    public async Task AddAsync(ProdutoRequest produtoRequest)
    {
        var produto = _produtoMapper.RequestToDomain(produtoRequest);

        var isProdutoValid = _produtoValidation.IsValid(produto);
        if (!isProdutoValid.IsValid)
        {
            foreach(var error in isProdutoValid.Errors)
            {
                _notificationHandler.AddNotification("Product error", error);
            }

            return;
        }

        await _produtoRepository.AddAsync(produto);
    }

    public async Task<List<ProdutoResponse>> GetAllAsync()
    {
        var produtoList = await _produtoRepository.GetAllAsync();

        var produtoResponseList = new List<ProdutoResponse>();
        foreach(var produto in produtoList)
        {
            produtoResponseList.Add(_produtoMapper.DomainToResponse(produto));
        }

        return produtoResponseList;
    }
}
