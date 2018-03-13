using System;
using Oop1.Figures.Visitors;

namespace Oop1.Figures
{
    public class Triangle : BaseDrawableFigure
    {
        public Triangle()
        {
        }

        public Triangle(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }

        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}