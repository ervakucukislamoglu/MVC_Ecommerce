using MVC_Ecommerce.Models.Context;
using MVC_Ecommerce.Models.Entity;
using MVC_Ecommerce.Repositoy;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Ecommerce.Service
{
    public class ProductService : IProductRepository
    {
        AppDbContext db = new AppDbContext();
        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }
    }
}
