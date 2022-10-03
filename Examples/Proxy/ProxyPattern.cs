using Interfaces;
using Interfaces.Proxy;

namespace Examples.Proxy
{
  public class ProxyPattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Proxy Pattern! \n");

      var aYouTubeService = new ThirdPartyYouTubeClass();
      var aYouTubeProxy = new CachedYouTubeClass(aYouTubeService);
      var manager = new YouTubeManager(aYouTubeProxy);
      manager.ReactOnUserInput();
    }
  }
}