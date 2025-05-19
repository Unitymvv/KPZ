namespace ClassLibrary_Task5
{
    public class TextDocument
    {
        private string _text = string.Empty;

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }

        public DocumentMemento Save()
        {
            return new DocumentMemento(_text);
        }

        public void Restore(DocumentMemento memento)
        {
            _text = memento.Text;
        }
    }
}
