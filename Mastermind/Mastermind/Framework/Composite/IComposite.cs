using System.Collections.Generic;
using Mastermind.Framework.Sprite;
using Mastermind.Framework.Vistor;

namespace Mastermind.Framework.Composite
{
    interface IComposite<T>
    {
        void AddChildren(T sprite);
        void RemoveChildren(T sprite);

        List<T> Children { get; }

        void AcceptComposite(ICompositeVistor<T> visitor);
        void Accept(IVisitor<T> visitor);
    }
}
