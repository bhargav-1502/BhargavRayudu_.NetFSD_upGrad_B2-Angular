using System;

namespace Week5Day1
{
    class Product
    {
        private double price;

        public string Name { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative");
            }
        }

        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }

    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05);
        }
    }

    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15);
        }
    }

    class Online_Shopping_Cart_System
    {
        static void Main()
        {
            Product electronics = new Electronics();

            electronics.Name = "Laptop";
            electronics.Price = 20000;

            Console.WriteLine("Final Price after 5% discount = " + electronics.CalculateDiscount());
        }
    }
}
