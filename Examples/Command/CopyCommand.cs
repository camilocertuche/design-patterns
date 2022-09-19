namespace Examples.Command
{
  public class CopyCommand : Command
  {
    public CopyCommand(App app, Editor editor) : base(app, editor) {}
    public override void Execute() => _app.Clipboard = _editor.GetSelection();
  }
}