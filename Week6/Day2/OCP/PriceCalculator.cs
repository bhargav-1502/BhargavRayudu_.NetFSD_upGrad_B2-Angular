using System;

namespace OCP
{
    internal class PriceCalculator
    {
        private IDiscountStrategy _discountStrategy;
        public PriceCalculator(IDiscountStrategy discountStrategy) 
        {
            _discountStrategy = discountStrategy;
        }

        public double GetFinalPrice(double amount)
        {
            double discount = _discountStrategy.CalculateDiscount(amount);
            return amount - discount;
        }
    }
}