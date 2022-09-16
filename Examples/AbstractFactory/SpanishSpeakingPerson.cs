using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class SpanishSpeakingPerson : IPerson
  {
    public void Greet() => Console.WriteLine("¡Hola mundo!");
  }
}