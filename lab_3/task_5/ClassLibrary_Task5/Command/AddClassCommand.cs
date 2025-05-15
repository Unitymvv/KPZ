namespace ClassLibrary_Task5.Command
{
    public class AddClassCommand : ICommand
    {
        private readonly LightElementNode _element;
        private readonly string _className;

        public AddClassCommand(LightElementNode element, string className)
        {
            _element = element;
            _className = className;
        }

        public void Execute()
        {
            if (!_element.CssClasses.Contains(_className)) 
                _element.CssClasses.Add(_className);
        }

        public void Undo()
        {
            _element.CssClasses.Remove(_className);
        }
    }
}
