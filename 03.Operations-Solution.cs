using System;

class Program
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        string operations = Console.ReadLine();

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
