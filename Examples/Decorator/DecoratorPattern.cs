using Interfaces;

namespace Examples.Decorator 
{
  public class DecoratorPattern : IDesignPatternExample
  {
    public void Execute() 
    {
      Console.WriteLine("Decorator Pattern!\n");

      // Create object that will be decorated
      Pizza pizza = new Pizza();

      // Decorating
      HamAddition ham = new HamAddition(1500, pizza);
      PineappleAddition pineapple = new PineappleAddition(1000, ham);

      Console.WriteLine($"Final price: {pineapple.Price()}");
    }
  }
}