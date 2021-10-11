using System;
using System.Collections.Generic;
using System.Text;

namespace AgafonovTheBest
{
    class QuadraticEquation : LinearEquation, EquationInterface
    {

        public List<float> solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return calcLinearEquation(b, c);
            }

            double discriminant = calcDiscriminant(a, b, c);

            if (discriminant < 0)
                throw new ArgumentException("Дискриминант меньше нуля");

            if (discriminant == 0)
                return x = new List<float>() { -b / (2 * a) };

            discriminant = Math.Sqrt(discriminant);

            return x = new List<float>() { (float)(-b + discriminant) / (2 * a), (float)(-b - discriminant) / (2 * a) };
        }

        private float calcDiscriminant(float a, float b, float c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
