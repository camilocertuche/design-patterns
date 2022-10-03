using Interfaces.Proxy;

namespace Examples.Proxy
{
  public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib
  {
    public List<string> ListVideos() => new() { "Video1", "Video2" };
    public string GetVideoInfo(int videoId) => $"Video info id: {videoId}";
    public void DownloadVideo(int videoId) => Console.WriteLine($"Downloading video info id: {videoId}");
  }
}