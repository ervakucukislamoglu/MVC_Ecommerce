using MVC_Ecommerce.Models.Entity;
using System.Collections.Generic;

namespace MVC_Ecommerce.Repositoy
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
    }
}
