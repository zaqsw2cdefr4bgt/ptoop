using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal abstract class BaseDrawer : IDrawer 
    {
        public abstract void Draw(Graphics graphics, Pen pen, int x, int y);
    }
}
