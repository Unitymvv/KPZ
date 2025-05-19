using System;
using System.Collections.Generic;

namespace ClassLibrary_Task5
{
    public class TextEditor
    {
        private TextDocument _document = new TextDocument();
        private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

        public void TypeText(string newText)
        {
            _history.Push(_document.Save());
            _document.SetText(newText);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Restore(memento);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Show()
        {
            Console.WriteLine("Current Document: " + _document.GetText());
        }
    }
}
