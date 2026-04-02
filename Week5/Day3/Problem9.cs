using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCodeTemplate
{
    internal class Problem9
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var result = products
                .Where(p => p.ProCategory == "FMCG")
                .OrderByDescending(p => p.ProMrp)
                .FirstOrDefault();

            Console.WriteLine($"{result.ProCode}\t{result.ProName}\t{result.ProMrp}");

            Console.ReadLine();
        }
    }
}