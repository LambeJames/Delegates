using System;

namespace Delegates
{
    class Program
    {
        delegate double ArithmeticOperation(double operand1, double operand2);

        static void Main(string[] args)
        {
            ArithmeticOperation sum = (double number1, double number2) =>
            {
                return number1 + number2;
            };

            ArithmeticOperation minus = (double number1, double number2) =>
            {
                return number1 - number2;
            };

            Print(sum, 1, 6);
            Print(sum, 3, 9);
            Print(minus, 15, 9);

            Console.WriteLine();
        }

        static void Print(ArithmeticOperation operation, double num1, double num2)
        {
            Console.WriteLine($"Answer is: {operation(num1, num2)}");
        }
    }
}
