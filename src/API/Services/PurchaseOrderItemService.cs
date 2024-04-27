using API.DemoDapper.Interfaces.IRepositories;
using API.DemoDapper.Interfaces.IServices;
using API.EntityFramework.Entities;

namespace API.DemoDapper.Services
{
    public class PurchaseOrderItemService : IPurchaseOrderItemService
    {
        private readonly IPurchaseOrderItemRepository _purchaseOrderItemRepository;

        public PurchaseOrderItemService(IPurchaseOrderItemRepository purchaseOrderItemRepository)
        {
            _purchaseOrderItemRepository = purchaseOrderItemRepository;
        }
        public void AddNew(PurchaseOrderItem purchaseOrderItem)
        {
            purchaseOrderItem.Id = _purchaseOrderItemRepository.Insert(purchaseOrderItem);            
        }

        public void Delete(int id)
        {
            var purchaseOrderItem = GetById(id);
            if (purchaseOrderItem != null)
                _purchaseOrderItemRepository.Delete(purchaseOrderItem);
            else
                throw new Exception("Id not found!");
        }

        

        public PurchaseOrderItem GetById(int id)
        {
            return _purchaseOrderItemRepository.GetById(id);
        }

        public void Update(PurchaseOrderItem purchaseOrderItem)
        {
            _purchaseOrderItemRepository.Update(purchaseOrderItem);
        }
    }
}
