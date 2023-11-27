namespace Balta.NotificationContext;

public abstract class Notifiable
{
    public List<Notification> Notifications { get; set; }
    public bool IsValid => Notifications.Count == 0;

    public Notifiable()
    {
        Notifications = [];
    }

    public void AddNotification(Notification notification) => Notifications.Add(notification);

    public void AddNotifications(IEnumerable<Notification> notifications) => Notifications.AddRange(notifications);
}
