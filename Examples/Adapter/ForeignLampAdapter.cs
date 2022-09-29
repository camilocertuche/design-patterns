using Interfaces.Adapter;

namespace Examples.Adapter
{
  public class ForeignLampAdapter : IConnectable
  {
    private readonly ForeignLamp _lamp = new();

    public bool On { get => _lamp.Encendida; set => _lamp.Encendida = value; }
    public void TurnOn() => _lamp.Encender();
    public void TurnOff() => _lamp.Apagar();
  }
}