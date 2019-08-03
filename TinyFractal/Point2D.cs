using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class Point2D
    {
        private readonly double x, y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }

        public static Point2D Parse(string s)
        {
            s = s.Trim();
            int pos = s.IndexOf(",");
            double x = double.Parse(s.Substring(1, pos - 1));
            double y = double.Parse(s.Substring(pos + 1, s.Length - pos - 2));

            return new Point2D(x, y);
        }
    }
}
