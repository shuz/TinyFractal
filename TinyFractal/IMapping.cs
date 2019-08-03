using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public interface IMapping
    {
        Point2D Map(Point2D point);
    }
}
