using SistemaComercial.API.Interfaces.Services;
using SistemaComercial.API.Services;

namespace SistemaComercial.API.DependencyInjection;

public static class ServicesDependencyInjection
{
    public static void AddServicesDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<ICalculoDescontoService, CalculoDescontoService>();
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<IVendaService, VendaService>();
    }
}
