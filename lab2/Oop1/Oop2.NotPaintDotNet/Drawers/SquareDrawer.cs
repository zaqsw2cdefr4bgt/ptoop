using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal class SquareDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            graphics.DrawRectangle(pen, x, y, 50, 50);
        }
    }
}