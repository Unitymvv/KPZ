namespace ClassLibrary_Task5.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
