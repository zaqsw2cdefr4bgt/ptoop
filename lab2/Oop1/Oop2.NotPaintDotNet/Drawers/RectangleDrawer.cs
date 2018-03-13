using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal class RectangleDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            graphics.DrawRectangle(pen, x, y, 50, 100);
        }
    }
}