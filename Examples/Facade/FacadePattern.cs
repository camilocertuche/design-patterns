using Interfaces;

namespace Examples.Facade
{
  public class FacadePattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Facade Pattern! \n");

      // Creating facade class
      var shapeMaker = new ShapeMaker();

      // Using facade's methods
      shapeMaker.DrawCircle();
      shapeMaker.DrawRectangle();
      shapeMaker.DrawSquare();
    }
  }
}