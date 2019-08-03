using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class SimilitudeMappingMaker : IMappingMaker
    {
        private Line2D initialLine;
        private Line2D mappingLine;

        public Line2D InitialLine
        {
            get { return initialLine; }
        }

        public Line2D MappingLine
        {
            get { return mappingLine; }
        }

        public SimilitudeMappingMaker(Line2D initialLine, Line2D mappingLine)
        {
            this.initialLine = initialLine;
            this.mappingLine = mappingLine;
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", initialLine, mappingLine);
        }

        public static SimilitudeMappingMaker Parse(string s)
        {
            int pos = s.IndexOf("->");
            Line2D initialLine = Line2D.Parse(s.Substring(0, pos - 1));
            Line2D EndLine = Line2D.Parse(s.Substring(pos + 2));

            return new SimilitudeMappingMaker(initialLine, EndLine);
        }

        public IMapping Create()
        {
            double s = initialLine.Length / mappingLine.Length;

            double dx0 = (initialLine.Begin.X - initialLine.End.X) * s;
            double dy0 = (initialLine.Begin.Y - initialLine.End.Y) * s;
            double dx1 = mappingLine.Begin.X - mappingLine.End.X;
            double dy1 = mappingLine.Begin.Y - mappingLine.End.Y;

            double sqrNorm = dx0 * dx0 + dy0 * dy0;
            double cost = (dx1 * dx0 + dy1 * dy0) / sqrNorm;
            double sint = (dy1 * dx0 - dx1 * dy0) / sqrNorm;

            double dpx = mappingLine.Begin.X - (initialLine.Begin.X * cost - initialLine.Begin.Y * sint) * s;
            double dpy = mappingLine.Begin.Y - (initialLine.Begin.X * sint + initialLine.Begin.Y * cost) * s;

            return new SimilitudeMapping(s, cost, sint, dpx, dpy);
        }
    }
}
