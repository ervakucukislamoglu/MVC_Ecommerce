using System.Collections.Generic;

namespace MVC_Ecommerce.Models.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
