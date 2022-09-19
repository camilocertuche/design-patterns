namespace Examples.Command 
{
  public class Editor 
  {
    public string Text {get; set;} = "Hello World!";
    
    public string GetSelection() =>  Text.Substring(6);
    public void DeleteSelection() => Text = Text.Remove(6);
    public void ReplaceSelection(string text) => Text = Text.Replace(GetSelection(), text);
  }
}