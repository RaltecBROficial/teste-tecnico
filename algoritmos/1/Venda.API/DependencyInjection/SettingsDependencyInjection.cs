using SistemaComercial.API.Interfaces.Settings.NotificationSettings;
using SistemaComercial.API.Interfaces.Settings.ValidationSettings;
using SistemaComercial.API.Settings.NotificationSettings;
using SistemaComercial.API.Settings.ValidationSettings;

namespace SistemaComercial.API.DependencyInjection;

public static class SettingsDependencyInjection
{
    public static void AddSettingsDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<INotificationHandler, NotificationHandler>();
        services.AddScoped<IProdutoValidation, ProdutoValidation>();
    }
}
