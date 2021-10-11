using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LinearEquation
    {
        public const string MEGASUPERCONST = "MEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONSTMEGASUPERCONST";

        protected List<double> x;
        public List<double> calcLinearEquation(double a, double b)
        {
            if (a == 0)
                throw new ArgumentException("Нельзя делить на 0");

            x = new List<double>();

            x.Add(-b / a);
            return  x;
           
        }
    }
}
