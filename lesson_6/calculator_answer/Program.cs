using System;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the calculation method (addition, subtraction, multiplication, division): ");
            string method = Console.ReadLine().ToLower();

            double result;

            switch (method)
            {
                case "addition":
                    result = num1 + num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "subtraction":
                    result = num1 - num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "multiplication":
                    result = num1 * num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case "division":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid calculation method.");
                    break;
            }

            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string userDecision = Console.ReadLine().ToLower();
            if (userDecision != "yes")
            {
                continueCalculating = false;
            }
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}
