using ClassLibrary_Task5.Visitor;

namespace ClassLibrary_Task5
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
            OnCreated();
        }

        public override string OuterHTML => _text;

        public override string InnerHTML => _text;

        public override void Accept(IVisitor visitor) => visitor.VisitText(this);
    }
}