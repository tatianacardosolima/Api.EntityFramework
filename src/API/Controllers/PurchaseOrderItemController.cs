using API.DemoDapper.Services;
using API.EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.DemoDapper.Controllers
{
    [ApiController]
    [Route("api/purchase-orders-items")]

    public class PurchaseOrderItemController : ControllerBase
    {
        private readonly PurchaseOrderItemService _purchaseOrderItemService;

        public PurchaseOrderItemController(PurchaseOrderItemService purchaseOrderItemService)
        {
            _purchaseOrderItemService = purchaseOrderItemService;
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
           
            return Ok(_purchaseOrderItemService.GetById(id));
        }
        [HttpPost]        
        public IActionResult Post(PurchaseOrderItem purchaseOrderItem)
        { 
            _purchaseOrderItemService.AddNew(purchaseOrderItem);
            return Ok(purchaseOrderItem);
        }

        [HttpPut]        
        public IActionResult Put(PurchaseOrderItem purchaseOrderItem)
        {
            _purchaseOrderItemService.Update(purchaseOrderItem);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _purchaseOrderItemService.Delete(id);
            return Ok();
        }

    }
}
