using System;

namespace ISP
{
    internal class AdvancedPrinter : IPrinter, IScanner, IFax
    {
        public void Print(string document)
        {
            Console.WriteLine("Advanced Printer printing: " + document);
        }

        public void Scan(string document)
        {
            Console.WriteLine("Advanced Printer scanning: " + document);
        }

        public void Fax(string document)
        {
            Console.WriteLine("Advanced Printer faxing: " + document);
        }
    }
}

