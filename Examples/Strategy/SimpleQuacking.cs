using Interfaces.Strategy;

namespace Examples.Strategy {
  public class SimpleQuacking : IQuackBehavior {
    public void Quack() {
      Console.WriteLine("Quack: Simple Quacking");
    }
  }
}
