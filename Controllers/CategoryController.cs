using Microsoft.AspNetCore.Mvc;
using MVC_Ecommerce.Repositoy;
using System.Linq;

namespace MVC_Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        private IProductRepository _productService;

        public CategoryController(IProductRepository productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int id)
        {
            var item = _productService.GetAllProducts().Where(x => x.CategoryID == id).ToList();
            return View(item);
        }
        
    }
}
