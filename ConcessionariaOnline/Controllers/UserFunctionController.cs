using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOnline.Controllers
{
    [Route("api/user")]
    public class UserFunctionController : ControllerBase
    {
        private const string SUCCESS_MESSAGE = "Success.";

        private readonly IUserFunctions _userFunction;

        public UserFunctionController(IUserFunctions userFunctions)
        {
            _userFunction = userFunctions;
        }

        /// <summary>
        /// Add user into database
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddUserIntoDb([FromBody] User user)
        {
            var result = _userFunction.AddUserIntoDb(user);
            
            if (result.Status == SUCCESS_MESSAGE)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpDelete]
        public IActionResult RemoveUserFromDB([FromQuery] int id) {
            var result = _userFunction.RemoveUserFromDb(id);
            
            if (result.Status == SUCCESS_MESSAGE)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet]
        public IActionResult GetAllUsers() {
            var result = _userFunction.GetAllUsers();
            
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateUserName([FromBody] UpdateUserName updatedUserName) {
            var result = _userFunction.UpdateUserName(updatedUserName.UserId, updatedUserName.updatedName);
            
            if (result.Status == SUCCESS_MESSAGE)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost]
        [Route("/loginUser")]
        public IActionResult Login([FromBody] LoginRequest userData) {
            var result = _userFunction.Login(userData);
            
            if (result.Status == SUCCESS_MESSAGE)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}