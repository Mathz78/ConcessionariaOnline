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
    }
}