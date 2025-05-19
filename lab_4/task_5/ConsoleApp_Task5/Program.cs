using ClassLibrary_Task5;

namespace ConsoleApp_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();

            editor.TypeText("Hello");
            editor.Show();

            editor.TypeText("Hello, world!");
            editor.Show();

            editor.TypeText("Hello, world! Plus");
            editor.Show();

            editor.Undo();
            editor.Show();

            editor.Undo();
            editor.Show();

            editor.Undo();
            editor.Show();

            editor.Undo();
        }
    }
}