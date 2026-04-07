using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day4
{
    internal class problem3
    {
        static void Main()
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Monthly Sales Amount: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal sales) || sales < 0)
            {
                Console.WriteLine("Invalid Sales Amount!");
                return;
            }

            Console.Write("Enter Customer Feedback Rating (1-5): ");
            if (!int.TryParse(Console.ReadLine(), out int rating) || rating < 1 || rating > 5)
            {
                Console.WriteLine("Invalid Rating! Must be between 1 and 5.");
                return;
            }

            // Get Tuple values
            var performanceData = GetPerformanceData(sales, rating);

            // Pattern Matching
            string result = performanceData switch
            {
                ( >= 100000, >= 4) => "High Performer",
                ( >= 50000, >= 3) => "Average Performer",
                _ => "Needs Improvement"
            };

            Console.WriteLine("\n--- Employee Performance Report ---");
            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Sales Amount  : {performanceData.sales}");
            Console.WriteLine($"Rating        : {performanceData.rating}");
            Console.WriteLine($"Performance   : {result}");
        }

        // Method returning Tuple
        static (decimal sales, int rating) GetPerformanceData(decimal sales, int rating)
        {
            return (sales, rating);
        }
    }
}