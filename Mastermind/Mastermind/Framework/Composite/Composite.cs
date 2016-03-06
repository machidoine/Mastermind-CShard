using System.Collections.Generic;
using Mastermind.Framework.Sprite;
using Mastermind.Framework.Vistor;

namespace Mastermind.Framework.Composite
{
    abstract class Composite<T> : IComposite<T>
    {
        public List<T> Children { get; private set; }

        protected Composite()
        {
            Children = new List<T>();
        }

        public void AddChildren(T sprite)
        {
            Children.Add(sprite);
        }

        public void RemoveChildren(T sprite)
        {
            Children.Remove(sprite);
        }

        public void Accept(ICompositeVistor<T> visitor)
        {
            visitor.VisitComposite(this);
        }
        public abstract void Accept(IVisitor<T> vistor);
    }
}
