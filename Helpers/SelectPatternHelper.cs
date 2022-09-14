using Interfaces;
using Examples;

namespace Helpers {
  public static class SelectPatternHelper {
    public static IDesignPatternExample Execute() {
      return new StrategyPattern();
    }
  }
}