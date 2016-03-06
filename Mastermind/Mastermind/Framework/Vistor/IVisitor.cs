namespace Mastermind.Framework.Vistor
{
    interface IVisitor<T>
    {
        void Visit(T component);
    }
}
