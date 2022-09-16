using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class SpanishPeopleFactory : IPeopleFactory
  {
    public IPerson CreatePerson() => new SpanishSpeakingPerson();
  }
}