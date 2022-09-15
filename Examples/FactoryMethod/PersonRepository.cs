using Interfaces.FactoryMethod;

namespace Examples.FactoryMethod
{
  public class PersonRepository : IRepository<Person>
  {
    protected readonly List<Person> set = new();
    public void Add(Person entity) => set.Add(entity);
    public void Update(Person entity) 
    {
      // TODO: update logic
    }

    public void Remove(int id) 
    {
      Person Person = GetById(id);
      set.Remove(Person);
    }

    public Person GetById(int id) 
    {
      var entity = set.FirstOrDefault(s => s.Id == id);
      return entity == null ? new() : entity;
    }

    public List<Person> GetAll() => set;
  }
}