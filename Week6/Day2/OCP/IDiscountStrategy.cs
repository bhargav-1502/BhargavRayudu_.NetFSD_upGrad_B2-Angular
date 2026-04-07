using System;

namespace OCP
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }
}