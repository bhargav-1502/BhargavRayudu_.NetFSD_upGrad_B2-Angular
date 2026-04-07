using LSP;
using System;

namespace LSPDemo
{
    class Program
    {
        static void Main()
        {
            AreaCalculator calculator = new AreaCalculator();

            // Rectangle
            Shape rectangle = new Rectangle(10, 5);
            Console.WriteLine("Rectangle Area: " + calculator.GetArea(rectangle));

            // Circle
            Shape circle = new Circle(7);
            Console.WriteLine("Circle Area: " + calculator.GetArea(circle));
        }
    }
}