namespace Examples.Singleton 
{
  public class Singleton 
  {
    private static Singleton? _instance = null;
    private Singleton(){}
    public static Singleton GetInstance()
    {
      if (_instance != null)
        return _instance;

      _instance = new Singleton();
      return _instance;
    }
  }
}