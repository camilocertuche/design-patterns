namespace Interfaces.FactoryMethod 
{
  public interface IValidator<T>
  {
    public bool IsValidToAdd(T entity);
    public bool IsValidToUpdate(T entity);
  }
}