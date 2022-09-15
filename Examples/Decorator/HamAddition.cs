using Interfaces.Decorator;

namespace Examples.Decorator 
{
  public class HamAddition : IAddition 
  {
    public HamAddition(int price, IFoodProduct product) : base(price, product) {}
  }
}