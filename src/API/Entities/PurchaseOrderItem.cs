namespace API.EntityFramework.Entities
{

    public class PurchaseOrderItem : EntityBase
    {
        public PurchaseOrderItem()
        {        
        }
               
        public ProductValueObject Product { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Tax { get; set; }
        public int Discount { get; set; }

    }

    public class ProductValueObject : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public double CurrentPrice { get; set; }
        public double MaximumDiscountAllowed { get; set; }

    }
}
