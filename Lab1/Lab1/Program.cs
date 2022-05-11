using Lab1.Model;
using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Function a = new ConstantFunction(2);
            Function b = new ExponentialFunction(2);
            Function c = new PowerFunction(2, 3);
            Function d = new LogarithmFunction(2);
            Console.WriteLine(a.Derivative());
            Console.WriteLine(a.Calculate(1));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(b.Derivative());
            Console.WriteLine(b.Calculate(1));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(c.Derivative());
            Console.WriteLine(c.Calculate(1));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(d.Derivative());
            Console.WriteLine(d.Calculate(1));
        }
    }
}