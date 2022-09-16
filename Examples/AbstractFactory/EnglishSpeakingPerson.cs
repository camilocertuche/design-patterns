using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class EnglishSpeakingPerson : IPerson
  {
    public void Greet() => Console.WriteLine("Hello world!");
  }
}