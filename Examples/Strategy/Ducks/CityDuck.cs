namespace Examples.Strategy {
  public class CityDuck : Duck {
    public CityDuck(SimpleQuacking quacking, NoFlying flying) : base(quacking, flying) {}
  }
}