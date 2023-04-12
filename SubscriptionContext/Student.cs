using Balta.SharedContext;

namespace Balta.SubscriptionContext;

public class Studente : Base
{
  public string Name { get; set; }
  public string Email { get; set; }
  public User User { get; set; }
}