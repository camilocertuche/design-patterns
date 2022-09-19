namespace Examples.Command
{
  public class UndoCommand : Command
  {
    public UndoCommand(App app, Editor editor) : base(app, editor) {}
    public override void Execute() => _app.Undo();
  }
}