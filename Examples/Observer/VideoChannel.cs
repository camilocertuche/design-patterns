using Interfaces.Observer;

namespace Examples.Observer {
  public class VideoChannel : IObservable {
    public List<String> Videos { get; } = new();
    
    public void NewVideo(String newVideo) {
      Videos.Add(newVideo);
      Notify();
    }
  }
}