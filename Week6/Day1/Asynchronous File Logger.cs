using System;
using System.Threading.Tasks;

namespace Week6Day1
{
    internal class Asynchronous_File_Logger
    {
        static async Task Main()
        {
            Console.WriteLine("Application Started..\n");

            Task allLogs = Task.WhenAll(
                WriteLogAsync("User logged in"),
                WriteLogAsync("User clicked button"),
                WriteLogAsync("Data saved successfully"),
                WriteLogAsync("User logged out")
            );

            Console.WriteLine("\nMain thread is still running..\n");

            await allLogs;

            Console.WriteLine("\nAll logs written successfully!\n");
            Console.ReadLine();
        }

        static async Task WriteLogAsync(string message)
        {
            Console.WriteLine($"Start writing log: {message}");

            await Task.Delay(2000);

            Console.WriteLine($"Finished writing log: {message}");
        }
    }
}