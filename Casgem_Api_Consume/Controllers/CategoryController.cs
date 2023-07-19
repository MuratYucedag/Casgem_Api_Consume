using Microsoft.AspNetCore.Mvc;

namespace Casgem_Api_Consume.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
