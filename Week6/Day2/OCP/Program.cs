using System;

namespace OCP
{
    class Program
    {
        public static void Main()
        {
            double amount = 1000;

            IDiscountStrategy regular = new RegularCustomerDiscount();
            PriceCalculator regularCalc = new PriceCalculator(regular);
            Console.WriteLine("Regular Final Price: " + regularCalc.GetFinalPrice(amount));

            IDiscountStrategy premium = new PremiumCustomerDiscount();
            PriceCalculator premiumCalc = new PriceCalculator(premium);
            Console.WriteLine("Premium Final Price: " + premiumCalc.GetFinalPrice(amount));

            IDiscountStrategy vip = new VipCustomerDiscount();
            PriceCalculator vipCalc = new PriceCalculator(vip);
            Console.WriteLine("VIP Final Price: " + vipCalc.GetFinalPrice(amount));
        }
    }
}