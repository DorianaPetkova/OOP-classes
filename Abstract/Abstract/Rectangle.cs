using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Rectangle : IDraw 
    {
        private int width;
        public int Width { get { return width; } set { width = value; } }
        private int height;
        public int Height { get { return height; } set { height = value; } }

        public Rectangle(int initialWidth, int initialHeight)
        {
            Width = initialWidth;
            Height = initialHeight;
        }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i=1; i<this.height-1; ++i)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for(int i=1; i<width-1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
    
}
