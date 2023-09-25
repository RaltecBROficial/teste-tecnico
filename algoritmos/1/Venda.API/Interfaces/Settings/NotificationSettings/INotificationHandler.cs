using SistemaComercial.API.Settings.NotificationSettings;

namespace SistemaComercial.API.Interfaces.Settings.NotificationSettings;

public interface INotificationHandler
{
    public List<Notification> GetNotifications();
    public bool HasNotification();
    public bool AddNotification(string key, string message);
}
