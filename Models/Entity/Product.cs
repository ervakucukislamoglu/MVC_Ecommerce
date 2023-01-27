using System.Collections.Generic;

namespace MVC_Ecommerce.Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
        
        //Relation
        public Supplier Supplier { get; set; }
        public int SupplierID { get; set; }

        //Relation
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Order> Orders { get; set; }
    }
}
