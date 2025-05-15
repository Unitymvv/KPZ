namespace ClassLibrary_Task5.Visitor
{
    public interface IVisitor
    {
        void VisitElement(LightElementNode element);
        void VisitText(LightTextNode text);
    }
}
