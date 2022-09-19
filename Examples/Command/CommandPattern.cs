using Interfaces;

namespace Examples.Command
{
  public class CommandPattern : IDesignPatternExample
  {
    public void Execute()
    {
      Console.WriteLine("Command pattern!\n");

      Editor editor = new();
      App app = new(editor);

      // Creating commands
      CopyCommand copyCommand = new(app, editor);
      CutCommand cutCommand = new(app, editor);
      PasteCommand pasteCommand = new(app, editor);
      UndoCommand undoCommand = new(app, editor);

      // Executing commands
      Console.Write("Copy:");
      app.ExecuteCommand(copyCommand);

      Console.Write("Cut:");
      app.ExecuteCommand(cutCommand);

      Console.Write("Undo:");
      app.ExecuteCommand(undoCommand);

      Console.Write("Paste:");
      app.Clipboard = "there!";
      app.ExecuteCommand(pasteCommand);
    }
  }
}