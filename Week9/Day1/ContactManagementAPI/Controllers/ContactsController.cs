using ContactManagement.API.Data;
using ContactManagement.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Contacts.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return Ok(contact);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact model)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            contact.Name = model.Name;
            contact.Email = model.Email;
            contact.Phone = model.Phone;

            _context.SaveChanges();

            return Ok(contact);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return Ok("Deleted Successfully");
        }
    }
}