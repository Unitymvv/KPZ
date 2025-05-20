namespace ClassLibrary_Task5.Visitor
{
    public class ElementCounterVisitor : IVisitor
    {
        public int ElementCount { get; private set; }
        public int TextCount { get; private set; }

        public void VisitElement(LightElementNode element)
        {
            ElementCount++;
            foreach (var child in element.Children)
                child.Accept(this);
        }

        public void VisitText(LightTextNode text) => TextCount++;
    }
}
