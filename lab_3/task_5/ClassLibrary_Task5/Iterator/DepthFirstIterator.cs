using System.Collections.Generic;

namespace ClassLibrary_Task5.Iterator
{
    public class DepthFirstIterator : IIterator
    {
        private Stack<LightNode> _stack = new Stack<LightNode>();

        public DepthFirstIterator(LightNode root)
        {
            _stack.Push(root);
        }

        public bool HasNext() => _stack.Count > 0;

        public LightNode Next()
        {
            var node = _stack.Pop();

            if (node is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    _stack.Push(child);
                }
            }
            return node;
        }
    }
}