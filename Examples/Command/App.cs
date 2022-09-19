namespace Examples.Command
{
  public class App
  {
    public Editor _editor {get; }
    public CommandHistory _history = new();
    public string Clipboard {get; set; } = "";

    public App(Editor editor)
    {
      _editor = editor;
      PrintState();
    }

    public void ExecuteCommand(Command command)
    {
      command.Execute();
      _history.Push(command);
      PrintState();
    }

    public void Undo()
    {
      Command command = _history.Pop();
      if (command != null)
        command.Undo();
    }

    private void PrintState() 
      => Console.WriteLine($"Text: {_editor.Text} \nClipboard: {Clipboard}\n");
  }
}