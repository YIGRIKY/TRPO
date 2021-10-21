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
            {
                throw new AgafonovException("Уравнения не существует");
            }
                

            AgafonovLog.I().Log("Это линейное уравнение");
            return x = new List<float>() { -b / a };
        }
    }
}
