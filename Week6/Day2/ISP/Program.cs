using System;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter basic = new BasicPrinter();
            basic.Print("Doc1");

            Console.WriteLine();

            AdvancedPrinter advanced = new AdvancedPrinter();
            advanced.Print("Doc2");
            advanced.Scan("Doc2");
            advanced.Fax("Doc2");
        }
    }
}