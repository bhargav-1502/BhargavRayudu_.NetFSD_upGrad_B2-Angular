using System;

namespace Week4Day4
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
    internal class Simple_Calculator_Using_Methods
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int addResult = calc.Add(a, b);
            int subResult = calc.Subtract(a, b);

            Console.WriteLine("Addition = " + addResult);
            Console.WriteLine("Subtraction = " + subResult);

            Console.ReadLine();
        }
    }
}
