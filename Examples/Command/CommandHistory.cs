namespace Examples.Command
{
  public class CommandHistory
  {
    private Stack<Command> _history = new();

    public void Push(Command command) => _history.Push(command);

    public Command Pop() => _history.Pop();
  }
}