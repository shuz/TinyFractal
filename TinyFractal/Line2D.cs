using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class Line2D
    {
        private Point2D begin, end;
        private CachedValue<double> length;
        private CachedValue<double> dx, dy;

        public Line2D(double beginX, double beginY, double endX, double endY)
            : this(new Point2D(beginX, beginY), new Point2D(endX, endY)) { }

        public Line2D(Point2D begin, Point2D end)
        {
            this.begin = begin;
            this.end = end;
            
            dx = new CachedValue<double>(GetDX);
            dy = new CachedValue<double>(GetDY);
            length = new CachedValue<double>(GetLength);
        }
        
        public double DX
        {
            get { return dx; }
        }

        public double DY
        {
            get { return dy; }
        }

        public double Length
        {
            get { return length; }
        }

        public Point2D Begin
        {
            get { return begin; }
        }

        public Point2D End
        {
            get { return end; }
        }

        private double GetLength()
        {
            double dx = DX;
            double dy = DY;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private double GetDX()
        {
            return end.X - begin.X;
        }

        private double GetDY()
        {
            return end.Y - begin.Y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", begin, end);
        }

        public static Line2D Parse(string s)
        {
            s = s.Trim();
            int pos = s.IndexOf(")");
            Point2D begin = Point2D.Parse(s.Substring(1, pos));
            pos = s.IndexOf(",", pos);
            Point2D end = Point2D.Parse(s.Substring(pos + 1, s.Length - pos - 2));

            return new Line2D(begin, end);
        }
    }
}
