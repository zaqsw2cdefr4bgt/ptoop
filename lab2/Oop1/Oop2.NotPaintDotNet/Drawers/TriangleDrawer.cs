using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal class TriangleDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            Point[] p = new Point[4];
            p[0].X = x;
            p[0].Y = y;
            p[1].X = x+50;
            p[1].Y = y+50;
            p[2].X = x - 50;
            p[2].Y = y + 50;
            p[3].X = x;
            p[3].Y = y;
            graphics.DrawPolygon(pen, p);
        }
    }
}