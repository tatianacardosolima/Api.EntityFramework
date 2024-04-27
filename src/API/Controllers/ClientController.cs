using API.DemoDapper.Interfaces.IServices;
using API.EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.DemoDapper.Controllers
{
    [ApiController]
    [Route("api/clients")]

    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet()]
        public IActionResult Get(int page=1, int size=10)
        {
            return Ok(_clientService.Get(page,size));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var client = _clientService.GetById(id);
            if (client == null) 
            {
                return NotFound();
            }
            return Ok(client);
        }
        [HttpPost]        
        public IActionResult Post(Client client)
        {
            _clientService.AddNew(client);
            return Ok(client);
        }

        [HttpPut]        
        public IActionResult Put(Client client)
        {
            _clientService.Update(client);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clientService.Delete(id);
            
            return Ok();
        }

    }
}
