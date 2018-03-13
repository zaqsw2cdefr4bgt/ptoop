using System;
using Oop1.Figures.Visitors;

namespace Oop1.Figures
{
    public class Square : BaseDrawableFigure
    {
        public Square()
        {
        }

        public Square(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }

        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}