using ClassLibrary_Task5;
using System.Collections.Generic;

namespace ClassLibrary_Task6
{
    public static class LightHTMLParser
    {
        public static List<LightNode> ParseLines(string[] lines, LightElementFlyweightFactory factory)
        {
            List<LightNode> htmlNodes = new List<LightNode>();

            for(int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();
                if (string.IsNullOrEmpty(line))
                    continue;

                LightElementType type;

                if (i == 0)
                    type = factory.GetElementType("h1", DisplayType.Block);
                else if (line.Length < 20)
                    type = factory.GetElementType("h2", DisplayType.Block);
                else if (char.IsWhiteSpace(line[0]))
                    type = factory.GetElementType("blockquote", DisplayType.Block);
                else
                    type = factory.GetElementType("p", DisplayType.Block);

                var element = new FlyweightLightElementNode(type);
                element.AddChild(new LightTextNode(line));
                htmlNodes.Add(element);
            }

            return htmlNodes;
        }
    }
}
