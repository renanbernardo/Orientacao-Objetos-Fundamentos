using Fundamentos.NotificationContext;

namespace Fundamentos.ContentContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}