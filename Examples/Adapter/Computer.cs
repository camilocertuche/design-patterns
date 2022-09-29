using Interfaces.Adapter;

namespace Examples.Adapter
{
  public class Computer : IConnectable
  {
    public bool On { get; set; }
    public void TurnOn() => On = true;
    public void TurnOff() => On = false;
  }
}