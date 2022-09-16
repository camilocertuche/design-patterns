using Interfaces;

namespace Examples.Singleton
{
  public class SingletonPattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Singleton pattern!\n");

      // Using GetInstance method instead of constructor
      Singleton s1 = Singleton.GetInstance();
      Singleton s2 = Singleton.GetInstance();

      Console.WriteLine($"s1: {s1.GetHashCode()}");
      Console.WriteLine($"s2: {s2.GetHashCode()}");
    }
  }
}