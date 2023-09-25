using SistemaComercial.API.Filters;

namespace SistemaComercial.API.DependencyInjection;

public static class FiltersDependencyInjection
{
    public static void AddFiltersDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<NotificationFilter>();
        services.AddMvc(s => s.Filters.Add<NotificationFilter>());
    }
}
