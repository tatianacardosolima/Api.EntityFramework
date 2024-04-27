using API.DemoDapper.Interfaces.IRepositories;
using API.EntityFramework.Entities;
using API.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace API.DemoDapper.Repositories
{
    public class PurchaseOrderItemRepository : IPurchaseOrderItemRepository
    {
        private readonly ExampleDBContext _context;

        public PurchaseOrderItemRepository(ExampleDBContext context)
        {
            _context = context;
        }

        public PurchaseOrderItemRepository()
        {

        }
        public void Delete(PurchaseOrderItem purchaseOrderItem)
        {
            _context.PurchaseOrderItem.Remove(purchaseOrderItem);
        }

        public List<PurchaseOrderItem> Get(int page = 1, int size = 10)
        {

            return _context.Set<PurchaseOrderItem>().Skip((page - 1) * size).Take(size)
                                 .AsNoTracking()
                                 .ToList();
        }

        public PurchaseOrderItem? GetById(int id)
        {
            return _context.PurchaseOrderItem.ToHashSet().FirstOrDefault(x => x.Id == id);
        }
            

        public int Insert(PurchaseOrderItem purchaseOrderItem)
        {
            _context.PurchaseOrderItem.Add(purchaseOrderItem);
            return purchaseOrderItem.Id;
        }

        public void Update(PurchaseOrderItem purchaseOrderItem)
        {
            _context.Set<PurchaseOrderItem>().Update(purchaseOrderItem);
        }
    }
}
