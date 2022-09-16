using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class FrenchSpeakingPerson : IPerson
  {
    public void Greet() => Console.WriteLine("Salut monde!");
  }
}