using Interfaces.Strategy;

namespace Examples.Strategy {
  public class NoQuacking : IQuackBehavior {
    public void Quack() {
      Console.WriteLine("Quack: No Quacking");
    }
  }
}
