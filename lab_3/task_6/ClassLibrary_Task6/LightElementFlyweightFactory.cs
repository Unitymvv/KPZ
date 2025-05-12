using ClassLibrary_Task5;
using System.Collections.Generic;

namespace ClassLibrary_Task6
{
    public class LightElementFlyweightFactory
    {
        private Dictionary<string, LightElementType> _types = new Dictionary<string, LightElementType>();

        public LightElementType GetElementType(string tagName, DisplayType display, bool closing = false)
        {
            string key = tagName + "_" + display + "_" + closing;
            if (!_types.ContainsKey(key))
            {
                _types[key] = new LightElementType(tagName, display, closing);
            }
            return _types[key];
        }

        public int GetFlyweightCount() => _types.Count;
    }
}
