using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day1
{
    internal class Debugging_Incorrect_Discount_Calculation
    {
        static void Main()
        {
            string productName;
            double productPrice;
            double discountPercentage;

            Console.Write("Enter Product Name: ");
            productName = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            productPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            discountPercentage = Convert.ToDouble(Console.ReadLine());

            double discountAmount = productPrice * discountPercentage / 100;
            double finalPrice = productPrice - discountAmount;


            Console.WriteLine("\nFinal Bill");
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Original Price: " + productPrice);
            Console.WriteLine("Discount (%): " + discountPercentage);
            Console.WriteLine("Discount Amount: " + discountAmount);
            Console.WriteLine("Final Price: " + finalPrice);

            Console.ReadLine();
        }
    }
}

