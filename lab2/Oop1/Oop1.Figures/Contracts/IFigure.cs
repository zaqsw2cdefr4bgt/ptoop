using Oop1.Figures.Visitors;

namespace Oop1.Figures.Contracts
{
    public interface IFigure
    {
        void Accept(IFigureVisitor visitor);
    }
}
