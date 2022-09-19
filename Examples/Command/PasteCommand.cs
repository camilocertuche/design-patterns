namespace Examples.Command
{
  public class PasteCommand : Command
  {
    public PasteCommand(App app, Editor editor) : base(app, editor) {}
    public override void Execute() 
    {
      SaveBackup();
      _editor.ReplaceSelection(_app.Clipboard);
    }
  }
}