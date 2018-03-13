using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal class LineDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            graphics.DrawLine(pen, x, y, x+100, y);
        }
    }
}