using Interfaces;

namespace Examples.Strategy {
  public class StrategyPattern : IDesignPatternExample {
    public void Execute() {
      Console.WriteLine("Strategy Pattern!");

      Console.WriteLine("\nCityDuck's behavior");
      Duck duck = new CityDuck(new(), new());
      duck.Quack();
      duck.Fly();

      Console.WriteLine("\nWildDuck's behavior");
      duck = new WildDuck(new(), new());
      duck.Quack();
      duck.Fly();
    }
  }
}