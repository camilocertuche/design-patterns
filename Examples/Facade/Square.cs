using Interfaces.Facade;

namespace Examples.Facade
{
  public class Square : IShape
  {
    public void Draw() => Console.WriteLine("Square.Draw()");
  }
}