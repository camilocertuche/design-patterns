using Interfaces;
using Examples.Strategy;

namespace Helpers {
  public static class SelectPatternHelper {
    public static IDesignPatternExample Execute() {
      return new StrategyPattern();
    }
  }
}