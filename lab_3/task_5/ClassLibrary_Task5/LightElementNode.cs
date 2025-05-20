using ClassLibrary_Task5.Iterator;
using ClassLibrary_Task5.State;
using ClassLibrary_Task5.Visitor;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Task5
{
    public class LightElementNode : LightNode
    {
        private IDisplayState _displayState;
        public string TagName { get; }
        public DisplayType Display { get; }
        public bool SelfClosing { get; }
        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType DisplayType = DisplayType.Block, bool selfClosing = false)
        {
            TagName = tagName;
            Display = DisplayType;
            SelfClosing = selfClosing;
            OnCreated();
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
            child.OnInserted();
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }

        public override string OuterHTML
        {
            get
            {
                string style = "style=\"" + _displayState?.ApplyStyle() + "\"" ?? string.Empty;
                string classAttr = CssClasses.Count > 0 ? " class=\"" + string.Join(" ", CssClasses) + "\"" : " ";
                if (SelfClosing)
                {
                    return "<" + TagName + classAttr + style + "/>";
                }
                else
                {
                    return "<" + TagName + classAttr + style + ">" + InnerHTML + "</" + TagName + ">";
                }
            }
        }

        public IIterator GetDepthFirstIterator() => new DepthFirstIterator(this);
        public IIterator GetBreadthFirstIterator() => new BreadthFirstIterator(this);

        public void SetDisplayState(IDisplayState state)
        {
            _displayState = state;
            OnStylesApplied();
        }

        public override void Accept(IVisitor visitor) => visitor.VisitElement(this);
    }
}