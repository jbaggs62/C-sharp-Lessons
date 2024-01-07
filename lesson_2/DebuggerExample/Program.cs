using System;

namespace DebuggingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = int.Parse(Console.ReadLine());
            int factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is {factorial}");
            Console.ReadLine();
        }

        static int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i; // Intentional bug: Should be 'i', not '1'
            }
            return result;
        }
    }
}
