using ContactApp.Models;
using ContactApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult ShowContacts()
        {
            var contacts = _contactService.GetAllContacts();
            return View(contacts);
        }

        public IActionResult GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
                ViewBag.Message = $"No contact found with ID {id}.";
            return View(contact);
        }

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(ContactInfo contactInfo)
        {
            _contactService.AddContact(contactInfo);
            return RedirectToAction("ShowContacts");
        }
    }
}