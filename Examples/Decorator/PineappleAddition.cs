using Interfaces.Decorator;

namespace Examples.Decorator 
{
  public class PineappleAddition : IAddition 
  {
    public PineappleAddition(int price, IFoodProduct product) : base(price, product) {}
  }
}