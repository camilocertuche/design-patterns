using Interfaces.Bridge;

namespace Examples.Bridge
{
  public class Tv : IDevice
  {
    private bool _isEnabled = false;
    private int _channel = 0;
    private int _volume = 0;

    public void Disable() 
    { 
      _isEnabled = false;
      Console.WriteLine("Tv disabled");
    }

    public void Enable()
    { 
      _isEnabled = true;
      Console.WriteLine("Tv enabled");
    }
    public int GetChannel() => _channel;

    public int GetVolume() => _volume;

    public bool IsEnabled() => _isEnabled;

    public void SetChannel(int channel) => _channel = channel;

    public void SetVolume(int volume) => _volume = volume;
  }
}