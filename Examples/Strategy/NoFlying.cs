using Interfaces.Strategy;

namespace Examples.Strategy {
  public class NoFlying : IFlyBehavior {
    public void Fly() {
      Console.WriteLine("Fly: No flying");
    }
  }
}