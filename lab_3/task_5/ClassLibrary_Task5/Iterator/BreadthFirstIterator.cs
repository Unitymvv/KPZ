using System.Collections.Generic;

namespace ClassLibrary_Task5.Iterator
{
    public class BreadthFirstIterator : IIterator
    {
        private Queue<LightNode> _queue = new Queue<LightNode>();

        public BreadthFirstIterator(LightNode root)
        {
            _queue.Enqueue(root);
        }

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            var node = _queue.Dequeue();

            if (node is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    _queue.Enqueue(child);
                }
            }
            return node;
        }
    }
}