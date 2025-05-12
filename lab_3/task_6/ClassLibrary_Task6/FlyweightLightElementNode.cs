using ClassLibrary_Task5;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary_Task6
{
    public class FlyweightLightElementNode : LightNode
    {
        private LightElementType _type;
        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        public FlyweightLightElementNode(LightElementType type)
        {
            _type = type;
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string InnerHTML => string.Concat(Children.Select(c => c.OuterHTML));

        public override string OuterHTML
        {
            get
            {
                string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (_type.SelfClosing)
                    return $"<{_type.TagName}{classAttr} />";
                return $"<{_type.TagName}{classAttr}>{InnerHTML}</{_type.TagName}>";
            }
        }
    }
}
