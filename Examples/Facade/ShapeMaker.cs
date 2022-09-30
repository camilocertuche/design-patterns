namespace Examples.Facade
{
  public class ShapeMaker
  {
    private readonly Circle _circle = new();
    private readonly Rectangle _rectangle = new();
    private readonly Square _square = new();
    
    public void DrawCircle() => _circle.Draw();
    public void DrawRectangle() => _rectangle.Draw();
    public void DrawSquare() => _square.Draw();
  }
}