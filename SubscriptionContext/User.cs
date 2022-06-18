using Fundamentos.SharedContext;

namespace Fundamentos.SubscriptionContext;

public class User : Base
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
