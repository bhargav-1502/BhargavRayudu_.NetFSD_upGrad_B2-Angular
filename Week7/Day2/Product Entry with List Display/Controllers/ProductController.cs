using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private static List<dynamic> products = new List<dynamic>();
        [Route("/")]
        [HttpGet("add")]
        public IActionResult Add()
        {
            ViewBag.Products = products;
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(string name, decimal price, int quantity)
        {
            products.Add(new
            {
                Name = name,
                Price = price,
                Quantity = quantity
            });

            ViewBag.Products = products;

            return View();
        }
    }
}