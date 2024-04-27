namespace API.EntityFramework.Entities
{

    public enum PurchaseOrderStatus
    {
        Registered = 0,
        AwaitingPayment = 1,
        PaidOut = 2,
    }
    public class PurchaseOrder:  EntityBase
    {
        public PurchaseOrder()
        {        
        }
        
        public Client Client{ get; set; }
        public int ClientId { get; set; }
        public DateTime DateIssue { get; set; }
        public PurchaseOrderStatus Status { get; set; }

    }
}
