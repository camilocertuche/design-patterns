namespace Examples.Command 
{
  public abstract class Command 
  {
    protected App _app;
    protected Editor _editor;
    protected string _backup;

    public Command(App app, Editor editor)
    {
      _app = app;
      _editor = editor;
      _backup = "";
    }

    public void SaveBackup() => _backup = _editor.Text;

    public void Undo() => _editor.Text = _backup;

    public abstract void Execute();
  }
}