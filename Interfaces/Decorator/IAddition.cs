namespace Interfaces.Decorator {
  public abstract class IAddition : IFoodProduct {
    protected readonly IFoodProduct _product;
    public IAddition(int price, IFoodProduct product) : base(price) {
      _product = product;
    }

    public override int Price() => _price + _product.Price();
  }
}