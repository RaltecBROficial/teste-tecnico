using SistemaComercial.API.Interfaces.Mappers;
using SistemaComercial.API.Mappers;

namespace SistemaComercial.API.DependencyInjection;

public static class MappersDependencyInjection
{
    public static void AddMappersDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IProdutoMapper, ProdutoMapper>();
        services.AddScoped<IProdutoVendaMapper, ProdutoVendaMapper>();
        services.AddScoped<IVendaMapper, VendaMapper>();
    }
}
