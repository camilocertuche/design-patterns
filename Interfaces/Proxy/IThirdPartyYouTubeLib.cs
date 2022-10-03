namespace Interfaces.Proxy
{
  public interface IThirdPartyYouTubeLib
  {
    public List<string> ListVideos();
    public string GetVideoInfo(int videoId);
    public void DownloadVideo(int videoId);
  }
}