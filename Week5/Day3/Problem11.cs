using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem11
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var result = products.Where(p => p.ProCategory == "FMCG").Count();

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}