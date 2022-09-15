using Interfaces.FactoryMethod;

namespace Examples.FactoryMethod
{
  public class Person : BaseEntity 
  {
    public string? Name { get; set; } = null;
    public string? Country { get; set; } = null;
  }
}