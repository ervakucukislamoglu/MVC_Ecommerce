using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MVC_Ecommerce.Models.Entity
{
    public class AppUser: IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public List<Order> Orders { get; set; }
    }
}
