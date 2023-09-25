using SistemaComercial.API.DataTransferObjects.Requests.Venda;
using SistemaComercial.API.DataTransferObjects.Responses.Venda;

namespace SistemaComercial.API.Interfaces.Services;

public interface IVendaService
{
    Task AddAsync(VendaRequest vendaRequest);
    Task<List<VendaResponse>> GetAllAsync();
}
