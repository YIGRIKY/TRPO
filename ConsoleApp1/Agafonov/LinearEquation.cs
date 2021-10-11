using System;
using System.Collections.Generic;
using System.Text;

namespace AgafonovTheBest
{
    class LinearEquation
    {
        public const string MEGASUPERCONST = "MEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONST";

        protected List<float> x;
        public List<float> calcLinearEquation(float a, float b)
        {
            if (a == 0)
                throw new ArgumentException("Нельзя делить на 0");

            x = new List<float>();

            x.Add(-b / a);
            return  x;
           
        }
    }
}
