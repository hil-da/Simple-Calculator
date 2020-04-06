using System;

namespace SimpleCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("-------------------");
            Console.WriteLine("Welcome!");
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter your first number:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter your second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect which of the following mathematical operations you want to use:");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\tb - Subtraction");
            Console.WriteLine("\tc - Multiplication");
            Console.WriteLine("\td - Division\n");
            Console.WriteLine("Your choice?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"\nResults: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "b":
                    Console.WriteLine($"\nResults: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "c":
                    Console.WriteLine($"\nResults: {num1} * {num2} = " + (num1 * num2));
                    break;

                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a denominator that is NOT zero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"\nResults: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
        }
    }
}

    