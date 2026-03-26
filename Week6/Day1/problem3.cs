using System;
using System.Threading;
using System.Threading.Tasks;

namespace Week6Day1
{
    class Problem3
    {
        static void Main()
        {
            Console.WriteLine("Starting report generation...\n");

            Task task1 = Task.Run(() => GenerateSalesReport());
            Task task2 = Task.Run(() => GenerateInventoryReport());
            Task task3 = Task.Run(() => GenerateCustomerReport());

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("\nAll reports have been generated successfully");

            Console.ReadLine();
        }

        static void GenerateSalesReport()
        {
            Console.WriteLine("Sales Report generation started...");
            Thread.Sleep(3000);
            Console.WriteLine("Sales Report generation completed.");
        }

        static void GenerateInventoryReport()
        {
            Console.WriteLine("Inventory Report generation started...");
            Thread.Sleep(4000);
            Console.WriteLine("Inventory Report generation completed.");
        }

        static void GenerateCustomerReport()
        {
            Console.WriteLine("Customer Report generation started...");
            Thread.Sleep(2000);
            Console.WriteLine("Customer Report generation completed.");
        }
    }
}