using Microsoft.AspNetCore.Mvc;
using ContactManagementAPI.Models;
using Microsoft.AspNetCore.RateLimiting;

namespace ContactManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private static readonly List<Contact> contacts = new()
        {
            new Contact { ContactId = 1, Name = "Ramesh", Email = "ramesh@gmail.com", Phone = "1234567890" },
            new Contact { ContactId = 2, Name = "Priya", Email = "priya@gmail.com", Phone = "9876543210" }
        };

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public IActionResult GetContacts()
        {
            return Ok(contacts);
        }
    }
}
