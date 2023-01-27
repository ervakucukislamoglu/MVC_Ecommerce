using System.Collections.Generic;

namespace MVC_Ecommerce.Models.Entity
{
    public class Supplier
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public List<Product> Products { get; set; }
    }
}
