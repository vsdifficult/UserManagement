using Microsoft.AspNetCore.Mvc;
using UsrManagemt.Models; 
using UsrManagemt.Services; 

namespace UsrManagemt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="user">Данные пользователя</param>
        /// <returns>Результат создания</returns>
        [HttpPost]
        public IActionResult CreateUser ([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddUser (user);
                return CreatedAtAction(nameof(GetAllUsers), new { id = user.Id }, user);
            }
            return BadRequest(ModelState);
        }

        // Другие действия (Edit, Details и т.д.) можно добавить аналогично
    }
}