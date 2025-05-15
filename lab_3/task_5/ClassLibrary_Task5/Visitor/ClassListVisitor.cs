using System.Collections.Generic;

namespace ClassLibrary_Task5.Visitor
{
    public class ClassListVisitor : IVisitor
    {
        public HashSet<string> Classes { get; } = new HashSet<string>();

        public void VisitElement(LightElementNode element)
        {
            foreach (var className in element.CssClasses)
                Classes.Add(className);

            foreach (var child in element.Children)
                child.Accept(this);
        }

        public void VisitText(LightTextNode text) { }
    }
}
