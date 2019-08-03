using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class CachedValue<T>
    {
        private T value;
        private bool initialized;

        private ValueCalculator calc;
        
        public delegate T ValueCalculator();

        public CachedValue(ValueCalculator calc)
        {
            this.calc = calc;
        }

        public static implicit operator T(CachedValue<T> cv)
        {
            if (cv.initialized == false)
            {
                T value = cv.calc();
                cv.value = value;
                cv.initialized = true;
            }
            return cv.value;
        }
    }
}
