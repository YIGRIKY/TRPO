using AgafonovTheBest;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AgafonovLog logger = AgafonovLog.I();
            logger.CheckAndCreateFolder();

            StreamReader reader = new StreamReader("../../../version");
            logger.Log($"Версия программы {reader.ReadLine()}");

            Console.WriteLine("Введите 3 параметра a, b и с");

            List<float> arguments = new List<float>(3);

            for (int i = 0; i < 3; i++)
            {
                arguments.Add(float.Parse(Console.ReadLine()));
            }

            logger.Log($"Введено уравнение {arguments[0]}x^2 + {arguments[1]}x + {arguments[2]}");

            QuadraticEquation b = new QuadraticEquation();
            logger.Log(LinearEquation.MEGASUPERCONST);
            try
            {
                logger.Log("Корни уравнения: " + string.Join(", ",b.Solve(arguments[0], arguments[1], arguments[2]).ToArray()));
            }
            catch (AgafonovException e)
            {
                logger.Log(e.Message);
            }

            logger.Write();
            Console.ReadKey();
        }
    }
}
