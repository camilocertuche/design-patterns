using Interfaces.Strategy;

namespace Examples.Strategy {
  public class Duck {
    private readonly IQuackBehavior _quackBehavior;
    private readonly IFlyBehavior _flyBehavior;

    public Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior) {
      _quackBehavior = quackBehavior;
      _flyBehavior = flyBehavior;
    }

    public void Quack() {
      _quackBehavior.Quack();
    }

    public void Fly(){
      _flyBehavior.Fly();
    }
  }
}