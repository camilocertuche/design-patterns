using Interfaces;
using Examples.Observer;
using Examples.Strategy;
using Examples.Decorator;
using Examples.FactoryMethod;
using Examples.AbstractFactory;
using Examples.Singleton;
using Examples.Command;
using Examples.Adapter;
using Examples.Facade;
using Examples.Proxy;
using Examples.Bridge;

namespace Helpers {
  public static class SelectPatternHelper {
    public static IDesignPatternExample Execute() {
      return BuildPatternExample(ReadOption());
    }
    private static int ReadOption() {
      int option;

      do {
        ShowOptions();
        int.TryParse(Console.ReadLine(), out option);
      } while(!optionIsValid(option));

      return option;
    }

    private static void ShowOptions() {
      Console.WriteLine("Select a design pattern example\n");
      Console.WriteLine("0. Strategy");
      Console.WriteLine("1. Observer");
      Console.WriteLine("2. Decorator");
      Console.WriteLine("3. Factory Method");
      Console.WriteLine("4. Abstract Factory");
      Console.WriteLine("5. Singleton");
      Console.WriteLine("6. Command");
      Console.WriteLine("7. Adapter");
      Console.WriteLine("8. Facade");
      Console.WriteLine("9. Proxy");
      Console.WriteLine("10. Bridge");
    }
    private static bool optionIsValid(int option) => 0 <= option && option <= 10;

    private static IDesignPatternExample BuildPatternExample(int option) {
      switch (option) {
        case 1:
          return new ObserverPattern();
        case 2:
          return new DecoratorPattern();
        case 3:
          return new FactoryMethodPattern();
        case 4:
          return new AbstractFactoryPattern();
        case 5:
          return new SingletonPattern();
        case 6:
          return new CommandPattern();
        case 7:
          return new AdapterPattern();
        case 8:
          return new FacadePattern();
        case 9:
          return new ProxyPattern();
        case 10:
          return new BridgePattern();
        default:
          return new StrategyPattern();
      }
    }
  }
}