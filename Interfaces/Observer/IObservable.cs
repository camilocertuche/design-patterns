namespace Interfaces.Observer {
  public abstract class IObservable {
    private readonly List<IObserver> observers = new();
    
    public void Add(IObserver observer) {
      observers.Add(observer);
    }

    public void Remove(IObserver observer) {
      observers.Remove(observer);
    }

    public void Notify() {
      observers.ForEach(o => o.Update());
    }
  }
}