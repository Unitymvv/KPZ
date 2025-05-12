using ClassLibrary_Task5;

namespace ClassLibrary_Task6
{
    public class LightElementType
    {
        public string TagName { get; } 
        public DisplayType Display { get; }
        public bool SelfClosing { get; }

        public LightElementType(string tagName, DisplayType display, bool closing)
        {
            TagName = tagName;
            Display = display;
            SelfClosing = closing;
        }
    }
}
