using Microsoft.EntityFrameworkCore;
using SistemaComercial.API.Infra.Context;

namespace SistemaComercial.API.DependencyInjection;

public static class DependencyInjectionHandler
{
    public static void AddDependencyInjectionHandler(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddFiltersDependencyInjection();
        services.AddSettingsDependencyInjection();

        services.AddDbContext<SistemaComercialDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddRepositoriesDependencyInjection();
        services.AddMappersDependencyInjection();
        services.AddServicesDependencyInjection();
    }
}
