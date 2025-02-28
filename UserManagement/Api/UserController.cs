using Microsoft.AspNetCore.Mvc;
using UsrManagemt.Models; 
using UsrManagemt.Services;  
using UsrManagemt.Database; 

namespace UsrManagemt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DBActions _userRepository;

        public UserController(DBActions dBActions)
        {
            _userRepository = dBActions;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult CreateUser ([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddUser(user);
                return CreatedAtAction(nameof(GetAllUsers), new { id = user.ID }, user);
            }
            return BadRequest(ModelState);
        }

    }
}