using Microsoft.AspNetCore.Mvc;

namespace StudentApp.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(string studentName, int age, string course)
        {

            TempData["Name"] = studentName;
            TempData["Age"] = age;
            TempData["Course"] = course;

            return RedirectToAction("Display");
        }

        [HttpGet("display")]
        public IActionResult Display()
        {
            ViewBag.Name = TempData["Name"];
            ViewBag.Age = TempData["Age"];
            ViewBag.Course = TempData["Course"];

            return View();
        }
    }
}