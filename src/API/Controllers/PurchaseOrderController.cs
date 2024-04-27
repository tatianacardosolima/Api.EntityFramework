using API.DemoDapper.Interfaces.IServices;
using API.EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.DemoDapper.Controllers
{
    [ApiController]
    [Route("api/purchase-orders")]

    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService _purchaseOrderService;

        public PurchaseOrderController(IPurchaseOrderService purchaseOrderService)
        {
            _purchaseOrderService = purchaseOrderService;
        }

        //[HttpGet]
        //public IActionResult Get(int page=1, int size=10)
        //{
        //    List<dynamic> clients = new List<dynamic>();
        //    clients.Add(new { nome = "Joao", cpf = "123456458911" });
        //    clients.Add(new { nome = "Maria", cpf = "98765432125" });
        //    return Ok(clients);
        //}

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            
            return Ok(_purchaseOrderService.GetById(id));
        }
        [HttpPost]        
        public IActionResult Post(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderService.AddNew(purchaseOrder);
            return Ok(purchaseOrder);
        }

        [HttpPut]        
        public IActionResult Put(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderService.Update(purchaseOrder);
            return Ok(purchaseOrder);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _purchaseOrderService.Delete(id);
            return Ok();
        }

    }
}
