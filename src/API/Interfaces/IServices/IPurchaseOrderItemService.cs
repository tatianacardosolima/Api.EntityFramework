using API.EntityFramework.Entities;

namespace API.DemoDapper.Interfaces.IServices
{
    public interface IPurchaseOrderItemService
    {
        void AddNew(PurchaseOrderItem purchaseOrderItem);

        void Update(PurchaseOrderItem purchaseOrderItem);

        void Delete(int id);

        PurchaseOrderItem GetById(int id);
    }
}
