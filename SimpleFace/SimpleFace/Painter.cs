using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation.Media;

namespace SimpleFace
{
    public class Painter
    {
        private Bitmap bitmap;

        public Painter(Bitmap Canvas)
        {
            bitmap = Canvas;
        }

        public void PaintCentered(string Text, Font Font, Color Color)
        {

            int x, y = 0;
            FindCenter(Text, Font, out x, out y);

            bitmap.DrawText(Text, Font, Color, x, y);
        }

        private void FindCenter(string Text, Font Font, out int x, out int y)
        {
            int charWidth = Font.CharWidth('0');
            int size = Text.Length*charWidth;
            int center = Device.AgentSize/2;
            int centerText = size/2;
            x = center - centerText;

            y = center - (Font.Height/2);

        }
    }
}