using System;
using System.Diagnostics;
using System.IO;

namespace Week6Day1
{
    internal class Application_Tracing_for_Order_Processing
    {
        static void Main()
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener("traceLog.txt"));
            Trace.AutoFlush = true;

            Trace.TraceInformation("Order Processing Started");

            try
            {
                ValidateOrder();
                ProcessPayment();
                UpdateInventory();
                GenerateInvoice();

                Trace.TraceInformation("Order Processing Completed Successfully");
            }
            catch (Exception ex)
            {
                Trace.TraceError("ERROR OCCURRED: " + ex.Message);
            }

            Trace.TraceInformation("Application Execution Finished");

            Console.WriteLine("Order Processing done. Check 'traceLog.txt' for logs.");
        }

        static void ValidateOrder()
        {
            Trace.WriteLine("Step 1: Validating Order...");
        }

        static void ProcessPayment()
        {
            Trace.WriteLine("Step 2: Processing Payment...");
            throw new Exception("Payment Failed due to insufficient balance");
        }

        static void UpdateInventory()
        {
            Trace.WriteLine("Step 3: Updating Inventory...");
        }

        static void GenerateInvoice()
        {
            Trace.WriteLine("Step 4: Generating Invoice...");
        }
    }
}