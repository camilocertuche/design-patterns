using Interfaces;

namespace Examples.Observer {
  public class ObserverPattern : IDesignPatternExample {
    public void Execute() {
      Console.WriteLine("Observer Pattern!\n");

      // Create the observable
      VideoChannel videoChannel = new();

      // Create the observers
      EmailAccount emailAccount = new(videoChannel);
      MobileDevice mobileDevice = new(videoChannel);

      // Subscribe as observers
      videoChannel.Add(emailAccount);
      videoChannel.Add(mobileDevice);

      // Action that notifies observers
      videoChannel.NewVideo("Breaking news!");
    }
  }
}