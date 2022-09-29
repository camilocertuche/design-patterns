using Interfaces;
using Interfaces.Adapter;

namespace Examples.Adapter
{
  public class AdapterPattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Adapter pattern!\n");

      IConnectable lamp = new Lamp();
      TurnOnConnectable(lamp);

      IConnectable computer = new Computer();
      TurnOnConnectable(computer);

      IConnectable foreignLamp = new ForeignLampAdapter();
      TurnOnConnectable(foreignLamp);

    }

    private void TurnOnConnectable(IConnectable connectable)
    {
      connectable.TurnOn();
      Console.WriteLine(connectable.On);
    }
  }
}