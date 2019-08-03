using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class FractalParser
    {
        public static IFractal Parse(string s)
        {
            s = s.Trim();
            if (!s.StartsWith("{"))
            {
                return Fractal.Parse(s);
            }
            else
            {
                return RandomFractal.Parse(s);
            }
        }
    }
}
