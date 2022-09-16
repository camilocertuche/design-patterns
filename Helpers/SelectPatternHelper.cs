using Interfaces;
using Examples.Observer;
using Examples.Strategy;
using Examples.Decorator;
using Examples.FactoryMethod;
using Examples.AbstractFactory;

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
    }
    private static bool optionIsValid(int option) => 0 <= option && option < 5;

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
        default:
          return new StrategyPattern();
      }
    }
  }
}