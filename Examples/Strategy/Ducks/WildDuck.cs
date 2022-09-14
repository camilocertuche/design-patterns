namespace Examples.Strategy {
  public class WildDuck : Duck {
    public WildDuck(NoQuacking quacking, SimpleFlying flying) : base(quacking, flying) {}
  }
}