using Interfaces;

namespace Examples.FactoryMethod 
{
  public class FactoryMethodPattern : IDesignPatternExample 
  {
    public void Execute() 
    {
      Console.WriteLine("Factory Method Pattern!\n");

      // Create object that uses factory methods
      var service = new PersonService();

      // Using inherited behavior
      service.Add(new(){ Id = 1, Name = "Test", Country = "Colombia" });
      var person = service.GetById(1);
      Console.WriteLine($"Person found: {person.Name} {person.Country}");

      // This way any crud service could be created

    }
  }
}