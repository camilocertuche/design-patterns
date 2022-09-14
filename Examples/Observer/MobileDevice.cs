using Interfaces.Observer;

namespace Examples.Observer {
  public class MobileDevice : IObserver {
    private readonly VideoChannel _videoChannel;

    public MobileDevice(VideoChannel videoChannel) {
      _videoChannel = videoChannel;
    }
    public void Update() {
      int total = _videoChannel.Videos.Count();
      Console.WriteLine($"MobileDevice: New video! Total={total}");
    }
  }
}