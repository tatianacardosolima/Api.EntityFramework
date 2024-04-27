using API.EntityFramework.Entities;

namespace API.DemoDapper.Interfaces.IServices
{
    public interface IPurchaseOrderService
    {
        void AddNew(PurchaseOrder purchaseOrder);

        void Update(PurchaseOrder purchaseOrder);

        void Delete(int id);

        PurchaseOrder GetById(int id);
    }
}
