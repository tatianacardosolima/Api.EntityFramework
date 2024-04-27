using API.DemoDapper.Interfaces.IRepositories;
using API.EntityFramework.Entities;
using API.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace API.DemoDapper.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly ExampleDBContext _context;

        public PurchaseOrderRepository(ExampleDBContext context)
        {
            _context = context;
        }

        public PurchaseOrderRepository()
        {

        }
        public void Delete(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrder.Remove(purchaseOrder);
            _context.SaveChanges();
        }

        public List<PurchaseOrder> Get(int page = 1, int size = 10)
        {

            return _context.Set<PurchaseOrder>().Skip((page - 1) * size).Take(size)
                                 .AsNoTracking()
                                 .ToList();
        }

        public PurchaseOrder? GetById(int id)
        {
            return _context.PurchaseOrder.ToHashSet().FirstOrDefault(x => x.Id == id);
        }


        public int Insert(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrder.Add(purchaseOrder);
            _context.SaveChanges();
            return purchaseOrder.Id;
        }

        public void Update(PurchaseOrder purchaseOrder)
        {
            _context.Set<PurchaseOrder>().Update(purchaseOrder);
            _context.SaveChanges();
        }
    }
}
