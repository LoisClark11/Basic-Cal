using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Basic Calculator------------");
            Console.Write("Enter first number: ");
            string? input1 = Console.ReadLine();
            if (input1 == null)
            {
                Console.WriteLine("Input cannot be null.");
                return;
            }
            double num1 = Convert.ToDouble(input1);

            Console.Write("Enter operator (+, -, *, /): ");
            string? opera = Console.ReadLine();
            if (opera == null)
            {
                Console.WriteLine("Input cannot be null.");
                return;
            }

            Console.Write("Enter second number: ");
            string? input2 = Console.ReadLine();
            if (input2 == null)
            {
                Console.WriteLine("Input cannot be null.");
                return;
            }
            double num2 = Convert.ToDouble(input2);

            double result = 0;
            bool valid = true;

            switch (opera)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                        valid = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    valid = false;
                    break;
            }

            if (valid)
                Console.WriteLine($"Total: {result}");
        }
    }
}