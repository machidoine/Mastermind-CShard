using Mastermind.Framework.Composite;

namespace Mastermind.Framework.Vistor
{
    interface ICompositeVistor<T> : IVisitor<T>
    {
        void VisitComposite(IComposite<T> composite);
    }
}
