using Interfaces.FactoryMethod;

namespace Examples.FactoryMethod 
{
  public abstract class CrudService<T> 
  {
    protected readonly IRepository<T> _repository;
    protected readonly IValidator<T> _validator;

    public CrudService() 
    {
      // Using factory methods!
      _repository = CreateRepository();
      _validator = CreateValidator();
    }

    public void Add(T entity) 
    {
      if (_validator.IsValidToAdd(entity))
        _repository.Add(entity);
    }

    protected abstract IRepository<T> CreateRepository();
    protected abstract IValidator<T> CreateValidator();

    public void Update(T entity)
    {
      if (_validator.IsValidToUpdate(entity))
        _repository.Update(entity);
    }

    public void Remove(int id) => _repository.Remove(id);

    public T GetById(int id) => _repository.GetById(id);

    public List<T> GetAll() => _repository.GetAll();
  }
}