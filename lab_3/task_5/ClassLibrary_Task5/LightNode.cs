using ClassLibrary_Task5.Visitor;
using System;

namespace ClassLibrary_Task5
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        public abstract void Accept(IVisitor visitor);

        public virtual void OnCreated() => Console.WriteLine("Node create");
        public virtual void OnInserted() => Console.WriteLine("Node insert");
        public virtual void OnRemoved() { }
        public virtual void OnStylesApplied() { }
        public virtual void OnClassListApplied() { }
        public virtual void OnTextRendered() { }
    }
}