namespace MVC_Ecommerce.Models.Entity
{
    public class OrderDetails
    {
       
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
