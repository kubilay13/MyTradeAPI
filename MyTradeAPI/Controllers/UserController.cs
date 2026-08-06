using Microsoft.AspNetCore.Mvc;
using MyTradeAPI.DTOs.UserDTOs;
using MyTradeAPI.Services.UserService;

namespace MyTradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("UserList")]
        public  IActionResult GetAllUsers()
        {
            var users = _userService.getAllUsers();
            return Ok(users);   
        }

        [HttpPost("UserCreate")]
        public IActionResult CreateUser(CreateUserDto createUserDto)
        {
            var users= _userService.createUser(createUserDto);
            return Ok(users); 
        }

        [HttpDelete("UserDelete")]
        public IActionResult DeleteUser(int id)
        {
            var users = _userService.deleteUser(id);
            return Ok(users);
        }

        [HttpPut("UserUpdate")]
        public IActionResult UpdateUser(int id , CreateUserDto createUserDto)
        {
            var user = _userService.updateUser(id,createUserDto);

            if(user==null)
            {
                return NotFound("Kullanıcı Bulunamadı.");
            }

            return Ok(user);
        }
    }
}
