using System;

namespace Week5Day1
{    
        class Employee
        {
            public string Name { get; set; }
            public double BaseSalary { get; set; }

            public virtual double CalculateSalary()
            {
                return BaseSalary;
            }
        }

        class Manager : Employee
        {
            public override double CalculateSalary()
            {
                return BaseSalary + (BaseSalary * 0.20);
            }
        }

        class Developer : Employee
        {
            public override double CalculateSalary()
            {
                return BaseSalary + (BaseSalary * 0.10);
            }
        }

        class Employee_Salary_Calculator
    {
            static void Main()
            {
                double baseSalary = 50000;

                Employee manager = new Manager();
                manager.Name = "Manager";
                manager.BaseSalary = baseSalary;

                Employee developer = new Developer();
                developer.Name = "Developer";
                developer.BaseSalary = baseSalary;

                Console.WriteLine("Manager Salary = " + manager.CalculateSalary());
                Console.WriteLine("Developer Salary = " + developer.CalculateSalary());
            }
        }
    }
