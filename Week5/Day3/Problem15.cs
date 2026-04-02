using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem15
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var result = products.Any(p => p.ProMrp < 30);

            Console.WriteLine(result ? "There are products below MRP Rs.30" : "There are NO products below MRP Rs.30");

            Console.ReadLine();
        }
    }
}