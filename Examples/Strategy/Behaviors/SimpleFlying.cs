using Interfaces.Strategy;

namespace Examples.Strategy {
  public class SimpleFlying : IFlyBehavior {
    public void Fly() {
      Console.WriteLine("Fly: Simple flying");
    }
  }
}