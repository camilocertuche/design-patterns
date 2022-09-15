namespace Interfaces.FactoryMethod 
{
  public interface IRepository<T>
  {
    public void Add(T entity);
    public void Update(T entity);
    public void Remove(int id);
    public T GetById(int id);
    public List<T> GetAll();
  }
}