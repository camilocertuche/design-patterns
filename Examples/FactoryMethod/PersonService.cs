using Interfaces.FactoryMethod;

namespace Examples.FactoryMethod
{
  public class PersonService : CrudService<Person>
  {
    protected override IRepository<Person> CreateRepository() => new PersonRepository();
    protected override IValidator<Person> CreateValidator() => new PersonValidator();
  }
}