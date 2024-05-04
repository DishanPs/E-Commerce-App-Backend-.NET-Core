using ECommerceApp.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class LoginController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public LoginController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("register")]
        public ActionResult<User> RegisterUser(Login login)
        {
            // Check if the email is already registered
            if (_dbContext.Login.Any(l => l.email == login.email))
            {
                return Conflict("Email is already registered.");
            }

            _dbContext.Login.Add(login);
            _dbContext.SaveChanges();
            return CreatedAtAction(nameof(RegisterUser), new { id = login.Id }, login);
        }

        [HttpPost("login")]
        public ActionResult<User> Login(Login login)
        {
            // Check if the model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Find user by email
            var user = _dbContext.Users.FirstOrDefault(u => u.email == login.email);

            // Check if the user exists
            if (user == null)
            {
                return NotFound("User not found");
            }

            // Check if the password matches
            if (user.password != login.password)
            {
                return Unauthorized("Invalid Password");
            }

            var response = new
            {
                User = user,
                Message = "Login Successful"
            };

            return Ok(response);
        }
    }

}

