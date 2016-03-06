using Mastermind.Framework.Composite;

namespace Mastermind.Framework.Vistor
{
    abstract class CompositeVisitor<T> : ICompositeVistor<T> where T : IComposite<T>
    {
        public void VisitComposite(IComposite<T> composite)
        {
            composite.Children.ForEach(child => child.AcceptComposite(this));
            composite.Accept(this);
        }

        public abstract void Visit(T component);
    }
}
