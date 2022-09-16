using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class EnglishPeopleFactory : IPeopleFactory
  {
    public IPerson CreatePerson() => new EnglishSpeakingPerson();
  }
}