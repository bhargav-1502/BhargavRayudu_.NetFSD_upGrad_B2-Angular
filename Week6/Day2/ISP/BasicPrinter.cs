using System;

namespace ISP
{
    public class BasicPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Basic Printer printing: " + document);
        }
    }
}