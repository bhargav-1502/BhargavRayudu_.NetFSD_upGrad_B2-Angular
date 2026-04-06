using Microsoft.AspNetCore.Mvc;

namespace FeedbackApp.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
 
        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("form")]
        public IActionResult Form(string name, string comments, int rating)
        {
            string message;

            if (rating >= 4)
            {
                message = "Thank You for your valuable feedback!";
            }
            else
            {
                message = "We will improve based on your feedback.";
            }

            ViewData["Message"] = message;
            ViewData["Name"] = name;

            return View();
        }
    }
}