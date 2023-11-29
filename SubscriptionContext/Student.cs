using Balta.SharedContext;

namespace Balta.SubscriptionContext;

public class Student : Base
{
    public Student()
    {
        Subscriptions = [];
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }

    public IList<Subscription> Subscriptions { get; set; }

    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification( new("Premium", "O aluno já possui uma notificação ativa"));
            return;
        }

        Subscriptions.Add(subscription);
    }
    public bool IsPremium => Subscriptions.Any(s => !s.IsInactive);
}
