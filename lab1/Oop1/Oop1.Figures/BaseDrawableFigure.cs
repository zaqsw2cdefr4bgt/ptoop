using System;
using Oop1.Figures.Contracts;

namespace Oop1.Figures
{
    public abstract class BaseDrawableFigure : BaseFigure, IDrawableFigure
    {
        public ConsoleColor Color { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        protected BaseDrawableFigure()
        {
        }

        protected BaseDrawableFigure(ConsoleColor color, int coordinateX, int coordinateY)
        {
            Color = color;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}