using System;

namespace Week5Day1
{
    class Vehicle
    {
        private string brand;
        private double rentalRatePerDay;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double RentalRatePerDay
        {
            get { return rentalRatePerDay; }
            set { rentalRatePerDay = value; }
        }
        public virtual double CalculateRental(int days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Invalid number of rental days.");
                return 0;
            }

            return RentalRatePerDay * days;
        }
    }

    class Car : Vehicle
    {
        private const double InsuranceCharge = 500;
        public override double CalculateRental(int days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Invalid number of rental days.");
                return 0;
            }

            double total = (RentalRatePerDay * days) + InsuranceCharge;
            return total;
        }
    }

    class Bike : Vehicle
    {
        public override double CalculateRental(int days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Invalid number of rental days.");
                return 0;
            }

            double total = RentalRatePerDay * days;
            double discount = total * 0.05;

            return total - discount;
        }
    }

    internal class Vehicle_Rental_System
    {
        static void Main()
        {
            Vehicle vehicle;

            int days = 3;

            vehicle = new Car();
            vehicle.Brand = "Kia";
            vehicle.RentalRatePerDay = 2000;

            double totalRental = vehicle.CalculateRental(days);

            Console.WriteLine("Total Rental = " + totalRental);
        }
    }
}
