using Interfaces;
using Interfaces.AbstractFactory;

namespace Examples.AbstractFactory
{
  public class AbstractFactoryPattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Abstract Factory Pattern!\n");

      // Spanish factory
      IPeopleFactory peopleFactory = new SpanishPeopleFactory();
      IPerson person = peopleFactory.CreatePerson();
      person.Greet();

      // English factory
      peopleFactory = new EnglishPeopleFactory();
      person = peopleFactory.CreatePerson();
      person.Greet();

      // French factory
      peopleFactory = new FrenchPeopleFactory();
      person = peopleFactory.CreatePerson();
      person.Greet();
    }
  }
}