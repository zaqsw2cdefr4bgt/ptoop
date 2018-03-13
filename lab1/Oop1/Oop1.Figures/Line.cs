using System;
using Oop1.Figures.Visitors;

namespace Oop1.Figures
{
    public class Line : BaseDrawableFigure
    {
        public Line()
        {
        }
        public Line(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }
        
        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}
