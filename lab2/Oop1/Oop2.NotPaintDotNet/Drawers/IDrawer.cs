using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal interface IDrawer
    {
        void Draw(Graphics graphics, Pen pen, int x, int y);
    }
}