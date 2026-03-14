using System;

namespace Week4Day4
{
    class OrderCalculator
    {
        public double CalculateFinalAmount(double price, int quantity, double discount = 0, double shipping = 50)
        {
            double subtotal = price * quantity;
            double discountAmount = subtotal * (discount / 100);
            double finalAmount = subtotal - discountAmount + shipping;

            Console.WriteLine("Subtotal = " + subtotal);
            Console.WriteLine("Discount Applied = " + discountAmount);
            Console.WriteLine("Shipping Charge = " + shipping);
            Console.WriteLine("Final Payable Amount = " + finalAmount);
            Console.WriteLine();

            return finalAmount;
        }
    }

    internal class E_Commerce_Order_Calculator_using_Optional_Parameters
        {
            static void Main()
            {
                OrderCalculator order = new OrderCalculator();

                Console.WriteLine("Order 1 (Default discount and shipping)");
                order.CalculateFinalAmount(1000, 2);

                Console.WriteLine("Order 2 (With discount only)");
                order.CalculateFinalAmount(1000, 2, 10);

                Console.WriteLine("Order 3 (With discount and shipping)");
                order.CalculateFinalAmount(1000, 2, 10, 100);
            }
        }
    }

