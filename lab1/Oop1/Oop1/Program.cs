using System;
using System.Collections.Generic;
using Oop1.Figures.Contracts;

namespace Oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IDrawableFigure> figureCollection = new StaticDrawableFigureCollection();
            var figureDrawer = new FigureDrawer();

            Console.WriteLine("Drawing collection of figures...");
            Console.WriteLine();

            figureDrawer.DrawFigures(figureCollection);

            Console.WriteLine();
            Console.WriteLine("Drawing extendable figures...");
            Console.WriteLine();

            figureCollection = new StaticExtendableFigureCollection();
            figureDrawer.DrawFigures(figureCollection);

            Console.ReadLine();
        }
    }
}
