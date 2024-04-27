using API.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.EntityFramework.Repositories
{
    public class ExampleDBContext: DbContext
    {
        
        private readonly int _userId;

        public ExampleDBContext(DbContextOptions<ExampleDBContext> options, int userId) : base(options)
        {
            
            _userId = userId;
        }

        //public ApplicationDBContext()
        //{
            
        //}

        public DbSet<Client> Cliente { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExampleDBContext).Assembly);
        }
    }
}
