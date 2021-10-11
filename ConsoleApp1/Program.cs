using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation b = new QuadraticEquation();
            Console.WriteLine(b.calcLinearEquation(1, -2)[0]);
            foreach (var item in b.calcQuadraticEquation(-3, 7, 3))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
