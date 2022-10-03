using Interfaces;
using Interfaces.Bridge;

namespace Examples.Bridge
{
  public class BridgePattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Bridge Pattern! \n");

      var tv = new Tv();
      var remote = new RemoteControl(tv);
      remote.TogglePower();

      var radio = new Radio();
      var remote2 = new AdvancedRemoteControl(radio);
      remote2.TogglePower();
    }
  }
}