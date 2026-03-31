using Microsoft.AspNetCore.Mvc;
using Contact_Management_Web_Application.Models;

namespace Contact_Management_Web_Application.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        static List<ContactInfo> contacts = new List<ContactInfo>();

        [HttpGet("show")]
        public IActionResult ShowContacts()
        {
            return View(contacts);
        }

        [HttpGet("get")]
        public IActionResult GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
                ViewBag.Message = "Contact not found";

            return View(contact);
        }

        [HttpGet("add")]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddContact(ContactInfo contactInfo)
        {
            contacts.Add(contactInfo);
            return RedirectToAction("ShowContacts");
        }
    }
}