using Interfaces.Proxy;

namespace Examples.Proxy
{
  public class YouTubeManager
  {
    protected IThirdPartyYouTubeLib _service;

    public YouTubeManager(IThirdPartyYouTubeLib service) => _service = service;

    public void RenderVideoPage(int videoId)
    {
      string info = _service.GetVideoInfo(videoId);
      Console.WriteLine(info);
    }

    public void RenderListPanel()
    {
      List<string> list = _service.ListVideos();
      list.ForEach(v => Console.WriteLine(v));
    }

    public void ReactOnUserInput()
    {
      int initialVideo = 1;
      RenderVideoPage(initialVideo);
      RenderListPanel();
    }
  }
}