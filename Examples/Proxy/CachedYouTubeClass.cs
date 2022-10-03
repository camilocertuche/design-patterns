using Interfaces.Proxy;

namespace Examples.Proxy
{
  public class CachedYouTubeClass : IThirdPartyYouTubeLib
  {
    private readonly IThirdPartyYouTubeLib _service;
    private List<string> listCache = new();
    private string videoCache = "";
    public bool NeedReset {get; set; } = false;

    public CachedYouTubeClass(IThirdPartyYouTubeLib service) => _service = service;

    public List<string> ListVideos()
    {
      if (!listCache.Any() || NeedReset)
        listCache = _service.ListVideos();
      return listCache;
    }
    public string GetVideoInfo(int videoId) 
    {
      if (string.IsNullOrEmpty(videoCache) || NeedReset)
        videoCache = _service.GetVideoInfo(videoId);
      return videoCache;
    }
    public void DownloadVideo(int videoId) => _service.DownloadVideo(videoId);
  }
}