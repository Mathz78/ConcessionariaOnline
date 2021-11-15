using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOnline.Controllers
{
    [Route("api/user")]
    public class UserFunctionController : ControllerBase
    {
        private readonly IUserFunctions _userFunction;

        public UserFunctionController(IUserFunctions userFunctions)
        {
            _userFunction = userFunctions;
        }

        /// <summary>
        /// Adiciona usuário no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddUserIntoDb([FromBody] User user)
        {
            return Ok(_userFunction.AddUserIntoDb(user));
        }

        [HttpDelete]
        public IActionResult RemoveUserFromDB([FromQuery] int id) {
            return Ok(_userFunction.RemoveUserFromDb(id));
        }

    }
}