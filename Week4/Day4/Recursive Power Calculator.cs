using System;

namespace Week4Day4
{
    class RecursivePowerCalculator
    {
        public static int CalculatePower(int baseNum, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            return baseNum * CalculatePower(baseNum, exponent - 1);
        }
    }

    internal class Recursive_Power_Calculator
    {
        static void Main(string[] args)
        {
            int baseNum, exponent;

            Console.Write("Enter Base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Exponent: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            if (exponent < 0)
            {
                Console.WriteLine("Exponent must be a positive integer.");
                return;
            }

            int result = RecursivePowerCalculator.CalculatePower(baseNum, exponent);

            Console.WriteLine("\nBase: " + baseNum);
            Console.WriteLine("Exponent: " + exponent);
            Console.WriteLine("Result: " + result);
        }
    }
}