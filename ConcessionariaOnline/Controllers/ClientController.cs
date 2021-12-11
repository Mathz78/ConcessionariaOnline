using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOnline.Controllers
{
    [Route("api/client")]
    public class ClientController : ControllerBase
    {
        private const string SUCCESS_STATUS = "Success.";

        private readonly IClient _client;

        public ClientController(IClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Create a new client
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateCleint([FromBody] Client client)
        {
            var result = _client.CreateClient(client);
            
            if (result.Status == SUCCESS_STATUS)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        /// <summary>
        /// Return a list of all clients
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllClients()
        {
            var result = _client.GetAllClients();
            return Ok(result);
        }

        /// <summary>
        /// Return a list of all clients
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult DeleteClient([FromQuery(Name = "id")] int id)
        {
            var result = _client.DeleteUser(id);
            return Ok(result);
        }
    }
}