using SistemaComercial.API.Infra.Repositories;
using SistemaComercial.API.Interfaces.Repositories;

namespace SistemaComercial.API.DependencyInjection;

public static class RepositoriesDependencyInjection
{
    public static void AddRepositoriesDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IVendaRepository, VendaRepository>();
    }
}
