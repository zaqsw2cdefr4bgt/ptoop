﻿using System.Drawing;

namespace Oop2.NotPaintDotNet.Drawers
{
    internal class CircleDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            graphics.DrawEllipse(pen, x, y, 50, 50);
        }
    }
}