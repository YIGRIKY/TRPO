using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            C variable = new C(new A(), new B(new B(new A())));
        }
    }
}
