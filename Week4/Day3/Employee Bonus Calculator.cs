using System;

namespace Week4Day3
{
    internal class Employee_Bonus_Calculator
    {
        static void Main()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Experience: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            double bonus;

            if (experience < 2)
                bonus = salary * 0.05;
            else if (experience <= 5)
                bonus = salary * 0.10;
            else
                bonus = salary * 0.15;

            double finalSalary = (bonus > 0) ? salary + bonus : salary;

            Console.WriteLine("\nEmployee: " + name);
            Console.WriteLine("Bonus: " + bonus.ToString("C"));
            Console.WriteLine("Final Salary: " + finalSalary.ToString("C"));
        }
    }
}