using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class QuadraticEquation : LinearEquation
    {

        public List<double> calcQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                return calcLinearEquation(b, c);
            }

            double discriminant = calcDiscriminant(a, b, c);

            if (discriminant < 0)
                throw new ArgumentException("Дискриминант меньше нуля");

            if (discriminant == 0)
                return x = new List<double>(){ -b / (2 * a) };

            discriminant = Math.Sqrt(discriminant);

            return x = new List<double>(){(-b + discriminant) / (2 * a), (-b - discriminant) / (2 * a) };
            
        }
        private double calcDiscriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
