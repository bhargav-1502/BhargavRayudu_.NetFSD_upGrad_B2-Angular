using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContactService.DTOs;
using ContactService.Services;

namespace ContactService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _contactService.GetAllAsync();
            return Ok(contacts);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _contactService.GetByIdAsync(id);
            if (contact == null)
                return NotFound(new { Message = $"Contact with ID {id} not found." });
            return Ok(contact);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] ContactDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var created = await _contactService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.ContactId }, created);
        }


        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, [FromBody] ContactDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updated = await _contactService.UpdateAsync(id, dto);
            if (updated == null)
                return NotFound(new { Message = $"Contact with ID {id} not found." });
            return Ok(updated);
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _contactService.DeleteAsync(id);
            if (!deleted)
                return NotFound(new { Message = $"Contact with ID {id} not found." });
            return Ok(new { Message = "Contact deleted successfully." });
        }
    }
}