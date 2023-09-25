using SistemaComercial.API.DataTransferObjects.Responses.Venda;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Interfaces.Mappers;

public interface IVendaMapper
{
    VendaResponse DomainToResponse(Venda venda);
}
