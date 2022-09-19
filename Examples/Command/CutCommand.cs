namespace Examples.Command
{
  public class CutCommand : Command
  {
    public CutCommand(App app, Editor editor) : base(app, editor) {}
    public override void Execute() 
    {
      SaveBackup();
      _app.Clipboard = _editor.GetSelection();
      _editor.DeleteSelection();
    }
  }
}