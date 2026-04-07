using System;

namespace LSP
{
    public class AreaCalculator
    {
        public double GetArea(Shape shape)
        {
            return shape.CalculateArea(); 
        }
    }
}