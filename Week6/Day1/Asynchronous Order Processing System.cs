using System;
using System.Threading.Tasks;

namespace Week6Day1
{
    internal class Asynchronous_Order_Processing_System
    {
        static async Task Main()
        {
            Console.WriteLine("Order processing started...\n");
            await ProcessOrderAsync();
            Console.WriteLine("\nOrder completed successfully!");
            Console.ReadLine();
        }

        static async Task ProcessOrderAsync()
        {
            Console.WriteLine("Starting order steps...\n");
            await VerifyPaymentAsync();
            await CheckInventoryAsync();
            await ConfirmOrderAsync();
        }

        static async Task VerifyPaymentAsync()
        {
            Console.WriteLine("Verifying payment...");
            await Task.Delay(2000);
            Console.WriteLine("Payment verified.\n");
        }

        static async Task CheckInventoryAsync()
        {
            Console.WriteLine("Checking inventory...");
            await Task.Delay(1500);
            Console.WriteLine("Inventory available.\n");
        }

        static async Task ConfirmOrderAsync()
        {
            Console.WriteLine("Confirming order...");
            await Task.Delay(1000);
            Console.WriteLine("Order confirmed.\n");
        }
    }
}
