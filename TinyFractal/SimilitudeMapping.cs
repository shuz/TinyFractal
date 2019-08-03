using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class SimilitudeMapping : IMapping
    {
        private double s;
        private double cost, sint;
        private double dpx, dpy;

        public SimilitudeMapping(double s, double theta, double dpx, double dpy) 
            : this(s, Math.Cos(theta), Math.Sin(theta), dpx, dpy) { }

        public SimilitudeMapping(double s, double cost, double sint, double dpx, double dpy)
        {
            this.s = s;
            this.cost = cost;
            this.sint = sint;
            this.dpx = dpx;
            this.dpy = dpy;
        }

        #region IMapping Members

        public Point2D Map(Point2D point)
        {
            double x = (point.X * cost - point.Y * sint) * s + dpx;
            double y = (point.X * sint + point.Y * cost) * s + dpy;

            return new Point2D(x, y);
        }

        #endregion
    }
}
