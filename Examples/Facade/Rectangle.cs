using Interfaces.Facade;

namespace Examples.Facade
{
  public class Rectangle : IShape
  {
    public void Draw() => Console.WriteLine("Rectangle.Draw()");
  }
}