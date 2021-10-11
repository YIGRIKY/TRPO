using AgafonovTheBest;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AgafonovLog logger = AgafonovLog.I();

            Console.WriteLine("Введите 3 параметра a, b и с");

            List<float> arguments = new List<float>(3);

            for (int i = 0; i < 3; i++)
            {
                arguments.Add(float.Parse(Console.ReadLine()));
            }

            logger.log($"Введено уравнение {arguments[0]}x^2 + {arguments[1]}x + {arguments[2]}");

            QuadraticEquation b = new QuadraticEquation();
            logger.log(LinearEquation.MEGASUPERCONST);
            try
            {
                logger.log("Корни уравнения: " + string.Join(", ",b.solve(arguments[0], arguments[1], arguments[2]).ToArray()));
            }
            catch (AgafonovException e)
            {
                logger.log(e.Message);
            }

            logger.write();
            Console.ReadKey();
        }
    }
}
