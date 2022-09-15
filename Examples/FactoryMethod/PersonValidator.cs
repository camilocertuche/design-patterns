using Interfaces.FactoryMethod;

namespace Examples.FactoryMethod
{
  public class PersonValidator : IValidator<Person>
  {
    // Only is valid to add people fron Colombia lol
    public bool IsValidToAdd(Person person) => person.Country == "Colombia";
    // All people can be edited
    public bool IsValidToUpdate(Person person) => true;
  }
}