using Lab1.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Function func1 = new ConstantFunction(2);
            Function func2 = new LogarithmFunction(4);
            Function func3 = new ExponentialFunction(5);
            Function func4 = new PowerFunction(2, 4);

            List<Function> functions = new() { func1, func2, func3, func4 };

            double value = 2;
            Function maxFunction = func1;

            var maxResult = maxFunction.Calculate(value);
       
            foreach (var function in functions)
            {
                var result = function.Calculate(value);

                if (maxResult < result)
                {
                    maxResult = result;
                    maxFunction = function;
                }
            }
           
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Максимальное значение с использованием своего кода:");
            Console.WriteLine(maxFunction);
            Console.WriteLine(maxResult);
            Console.WriteLine("Максимальное значение с использованием System.Linq:");
            Console.WriteLine(functions.Max(function => function.Calculate(value)));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(func1.Derivative());
            Console.WriteLine(func1.Calculate(1));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(func2.Derivative());
            Console.WriteLine(func2.Calculate(1));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(func3.Derivative());
            Console.WriteLine(func3.Calculate(1));
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(func4.Derivative());
            Console.WriteLine(func4.Calculate(1));
        }
    }
}