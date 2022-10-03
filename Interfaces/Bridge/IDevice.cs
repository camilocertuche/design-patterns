namespace Interfaces.Bridge
{
  public interface IDevice
  {
    public bool IsEnabled();
    public void Enable();
    public void Disable();
    public int GetVolume();
    public void SetVolume(int percent);
    public int GetChannel();
    public void SetChannel(int channel);
  }
}