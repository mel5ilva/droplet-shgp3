using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/user
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userRepository.GetUsers();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }


        // GET: api/user/id/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        // GET: api/user/email/{email}/{senha}
        [HttpGet("{email}/{senha}")]
        public ActionResult<User> GetUserByemail(string email, string senha)
        {
            var user = _userRepository.GetUserByemail(email,senha);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        // POST: api/user
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            _userRepository.CreateUser(user);
            return Ok(); // Retorna uma resposta HTTP 200 (OK) sem nenhum conteúdo adicional
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            if (id != user.ID_usuario)
            {
                return BadRequest();
            }

            var existingUser = _userRepository.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            _userRepository.UpdateUser(user);

            return NoContent();
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var existingUser = _userRepository.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            _userRepository.DeleteUser(id);

            return NoContent();
        }
    }

}
