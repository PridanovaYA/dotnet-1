using Lab1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;

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

            AnsiConsole.WriteLine("______________________________________________________");
            AnsiConsole.WriteLine("Максимальное значение с использованием своего кода:");
            AnsiConsole.WriteLine(maxFunction.ToString());
            AnsiConsole.WriteLine(maxResult);
            AnsiConsole.WriteLine("Максимальное значение с использованием System.Linq:");
            AnsiConsole.WriteLine(functions.Max(function => function.Calculate(value)));
            AnsiConsole.WriteLine("______________________________________________________");

            while (true)
            {
                var functionType = AnsiConsole.Prompt(new SelectionPrompt<string>().Title("[blue]Выберите тип функции:[/]")
                    .AddChoices("Constant function", "Power function", "Exponential function", "Logarithm function"));

                Function chooseFunction = functionType switch
                {
                    "Constant function" => new ConstantFunction(
                        AnsiConsole.Prompt(new TextPrompt<double>("[red]Введите коэфициент:[/]"))),
                    "Power function" => new PowerFunction(
                        AnsiConsole.Prompt(new TextPrompt<double>("[red]Введите коэфициент:[/]")),
                        AnsiConsole.Prompt(new TextPrompt<double>("[red]Введите степень:[/]"))),
                    "Exponential function" => new ExponentialFunction(
                        AnsiConsole.Prompt(new TextPrompt<double>("[red]Введите базу:[/]"))),
                    "Logarithm function" => new LogarithmFunction(
                        AnsiConsole.Prompt(new TextPrompt<double>("[red]Введите базу:[/]"))),
                    _ => null
                };

                if (chooseFunction == null)
                {
                    AnsiConsole.MarkupLine($"[red]Неизвестнаый тип функции: {functionType}[/]");
                }

                functions.Add(chooseFunction);

                var table = new Table();
                table.AddColumn("[yellow]Type[/]");
                table.AddColumn("[green]Function[/]");
                table.AddColumn("[blue]Derivative[/]");
                int counter = 0;

                foreach (Function function in functions)
                {
                    if (counter < 10)
                    {
                        table.AddRow(function.GetType().Name, function.ToString(), function.Derivative().ToString());
                        ++counter;
                        continue;
                    }
                    table.AddRow("...", "...", "...");
                    break;
                }

                AnsiConsole.Write(table);

            }
        }
    }
}