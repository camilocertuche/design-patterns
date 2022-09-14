using Interfaces.Observer;

namespace Examples.Observer {
  public class EmailAccount : IObserver {
    private readonly VideoChannel _videoChannel;

    public EmailAccount(VideoChannel videoChannel) {
      _videoChannel = videoChannel;
    }
    public void Update() {
      int total = _videoChannel.Videos.Count();
      Console.WriteLine($"EmailAccount: New video! Total={total}");
    }
  }
}