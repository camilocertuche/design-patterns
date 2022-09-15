using Interfaces.Decorator;

namespace Examples.Decorator 
{
  public class Pizza : IFoodProduct 
  {
    public Pizza(int price = 5000) : base(price){}

    public override int Price() => _price;
  }
}