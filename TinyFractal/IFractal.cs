using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public interface IFractal
    {
        IList<Line2D> Iteration
        {
            get;
            set;
        }

        void Iterate();
        
        Point2D RandomTrace(Point2D point);
    }
}
