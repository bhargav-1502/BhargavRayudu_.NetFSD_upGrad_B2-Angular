using ContactManagement.API.Data;
using ContactManagement.API.Models;
using ContactManagement.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly JwtService _jwtService;

        public AuthController(AppDbContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public IActionResult Register(UserInfo user)
        {
            if (_context.Users.Any(x => x.EmailId == user.EmailId))
                return BadRequest("User already exists");

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new { message = "User Registered Successfully" });
        }

        [HttpPost("login")]
        public IActionResult Login(UserInfo login)
        {
            var user = _context.Users.FirstOrDefault(x =>
                x.EmailId == login.EmailId &&
                x.Password == login.Password);

            if (user == null)
                return Unauthorized("Invalid Credentials");

            var token = _jwtService.GenerateToken(user);

            return Ok(new { Token = token });
        }
    }
}