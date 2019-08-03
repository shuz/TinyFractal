using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class RandomKochCurve : IFractal
    {
        private List<Line2D> iteration;
        private static Random random = new Random();

        private double angel1 = -60 * Math.PI / 180.0;
        private double angel2 = +60 * Math.PI / 180.0;

        private double ratio;

        public RandomKochCurve(double ratio)
        {
            this.ratio = ratio;
        }

        public void Iterate()
        {
            List<Line2D> newIteration = new List<Line2D>();

            foreach (Line2D line in iteration)
            {
                double rangle = (random.NextDouble() <= ratio ? angel1 : angel2);
                double length = line.Length / 3;
                double a = Math.Atan2(line.DY, line.DX);
                a = a + rangle;
                Point2D p1 = new Point2D(line.Begin.X + line.DX / 3, line.Begin.Y + line.DY / 3);
                Point2D p2 = new Point2D(line.Begin.X + line.DX * 2 / 3, line.Begin.Y + line.DY * 2 / 3);
                Line2D cutSeg = new Line2D(p1.X, p1.Y, p2.X, p2.Y);
                Point2D p = new Point2D(cutSeg.Begin.X + length * Math.Cos(a), cutSeg.Begin.Y + length * Math.Sin(a));
                newIteration.Add(new Line2D(line.Begin.X, line.Begin.Y, p1.X, p1.Y));
                newIteration.Add(new Line2D(p1.X, p1.Y, p.X, p.Y));
                newIteration.Add(new Line2D(p.X, p.Y, p2.X, p2.Y));
                newIteration.Add(new Line2D(p2.X, p2.Y, line.End.X, line.End.Y));
            }

            this.iteration = newIteration;
        }

        #region IFractal Members

        public IList<Line2D> Iteration
        {
            get
            {
                return iteration;
            }
            set
            {
                iteration = new List<Line2D>(value);
            }
        }

        public Point2D RandomTrace(Point2D point)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
