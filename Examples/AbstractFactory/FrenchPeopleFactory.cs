using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class FrenchPeopleFactory : IPeopleFactory
  {
    public IPerson CreatePerson() => new FrenchSpeakingPerson();
  }
}