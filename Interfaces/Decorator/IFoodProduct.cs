namespace Interfaces.Decorator {
  public abstract class IFoodProduct {
    protected readonly int _price;

    public IFoodProduct(int price) {
      _price = price;
    }

    public abstract int Price();
  }
}