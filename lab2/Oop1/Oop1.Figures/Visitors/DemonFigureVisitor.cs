using System;
using Oop1.Figures.Contracts;

namespace Oop1.Figures.Visitors
{
    public class DemonFigureVisitor : IFigureVisitor
    {
        private void DemonizeFigure(IDrawableFigure figure)
        {
            if (figure == null)
            {
                return;
            }

            const int demonNumber = 666;
            figure.Color = ConsoleColor.DarkRed;
            figure.CoordinateX = demonNumber;
            figure.CoordinateY = demonNumber;
        }

        public void Visit(Circle figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Dot figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Line figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Rectangle figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Square figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Triangle figure)
        {
            DemonizeFigure(figure);
        }
    }
}