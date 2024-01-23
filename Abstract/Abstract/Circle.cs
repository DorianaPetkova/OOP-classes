using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Circle : IDraw
    {
        private int radius;
        public int Radius { get { return radius; } set { radius = value; } }

        public Circle(int initialrad)
        {
            radius = initialrad;
        }
        public void Draw()
        {
            double rin = this.radius - 0.4;
            double rout = this.radius + 0.4;
            for (double y = this.radius; y >= -this.radius; y--)
            {
                for (double x = -this.radius; x < rout; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rin * rout && value <= rout * rout)
                        Console.Write('*');
                    else Console.Write(' ');

                }
                Console.WriteLine();
            }
        }
    }
}
