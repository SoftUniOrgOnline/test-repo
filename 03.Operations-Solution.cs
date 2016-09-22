using System;

class Program
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        string operations = Console.ReadLine();

        if (operations == "+")
        {
            Console.Write($"{number1} + {number2} = {number1 + number2} - ");
            Console.WriteLine((number1 + number2) % 2 == 0 ? "even" : "odd");
        }
        else if (operations == "-")   //тук съм правил аз промени
        {
            Console.Write($"{number1} + {number2} = {number1 + number2} - ");   //тук
            Console.WriteLine((number1 + number2) % 2 == 0 ? "even" : "odd");   //и тук
            Console.Write($"{number1} - {number2} = {number1 - number2} - ");
            Console.WriteLine((number1 - number2) % 2 == 0 ? "even" : "odd");
        }
        else if (operations == "*")
        {
            Console.Write($"{number1} * {number2} = {number1 * number2} - ");
            Console.WriteLine((number1 * number2) % 2 == 0 ? "even" : "odd");
            Console.Write($"{number1} * {number2} = {number1 * number2} - ");
            Console.WriteLine((number1 * number2) % 2 == 0 ? "even" : "odd");
        }
        else if (operations == "/")
        {
            Console.WriteLine(number2 == 0
                ? $"Cannot divide {number1} by zero"
                : $"{number1} / {number2} = {(double)number1 / number2}");
        }
        else if (operations == "%")
        {
            Console.WriteLine(number2 == 0
                ? $"Cannot divide {number1} by zero"
                : $"{number1} % {number2} = {number1 % number2}");

            Console.WriteLine(number2 == 0
               ? $"Cannot divide {number1} by zero"
               : $"{number1} % {number2} = {number1 % number2}");
        }
    }
}
