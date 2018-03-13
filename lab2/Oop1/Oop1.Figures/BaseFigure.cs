using Oop1.Figures.Contracts;
using Oop1.Figures.Visitors;

namespace Oop1.Figures
{
    public abstract class BaseFigure : IFigure
    {
        public abstract void Accept(IFigureVisitor visitor);
    }
}