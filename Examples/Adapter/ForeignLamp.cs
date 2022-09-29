namespace Examples.Adapter
{
  public class ForeignLamp 
  {
    public bool Encendida { get; set; }
    public void Encender() => Encendida = true;
    public void Apagar() => Encendida = false;
  }
}