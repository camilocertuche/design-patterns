using Interfaces.Facade;

namespace Examples.Facade
{
  public class Circle : IShape
  {
    public void Draw() => Console.WriteLine("Cirlce.Draw()");
  }
}