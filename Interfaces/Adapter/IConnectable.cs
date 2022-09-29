namespace Interfaces.Adapter 
{
  public interface IConnectable 
  {
    public bool On { get; set; }
    public void TurnOn();
    public void TurnOff();
  }
}