using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MVC_Ecommerce.Models.Entity
{
    public class Order
    {
        public int ID { get; set; }
        public string ShipAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public string AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
