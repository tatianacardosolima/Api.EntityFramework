using API.DemoDapper.Interfaces.IRepositories;
using API.DemoDapper.Interfaces.IServices;
using API.EntityFramework.Entities;

namespace API.DemoDapper.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;

        public PurchaseOrderService(IPurchaseOrderRepository purchaseOrderRepository)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
        }
        public void AddNew(PurchaseOrder purchaseOrder)
        {
            purchaseOrder.Id = _purchaseOrderRepository.Insert(purchaseOrder);            
        }

        public void Delete(int id)
        {
            var purchaseOrderItem = GetById(id);
            if (purchaseOrderItem != null)
                _purchaseOrderRepository.Delete(purchaseOrderItem);
            else
                throw new Exception("Id not found!");
        }

        

        public PurchaseOrder GetById(int id)
        {
            return _purchaseOrderRepository.GetById(id);
        }

        public void Update(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderRepository.Update(purchaseOrder);
        }
    }
}
