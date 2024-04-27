using API.EntityFramework.Entities;

namespace API.DemoDapper.Interfaces.IRepositories
{
    public interface IPurchaseOrderRepository
    {
        int Insert(PurchaseOrder purchaseOrder);
        void Update(PurchaseOrder purchaseOrder);
        void Delete(PurchaseOrder purchaseOrder);
        PurchaseOrder? GetById(int id);

    }
}
