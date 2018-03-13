using System;

namespace Oop1.Figures.Contracts
{
    public interface IDrawableFigure : IFigure
    {
        ConsoleColor Color { get; set; }

        int CoordinateX { get; set; }
        int CoordinateY { get; set; }
    }
}