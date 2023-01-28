using Microsoft.AspNetCore.Mvc;
using MVC_Ecommerce.Repositoy;

namespace MVC_Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productService;

        public ProductController(IProductRepository productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAllProducts());
        }
    }
}
