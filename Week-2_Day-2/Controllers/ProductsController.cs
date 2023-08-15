using Microsoft.AspNetCore.Mvc;

namespace Week_2_Day_2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Index action.");
        }

        public IActionResult Details(int id)
        {
            return Content($"This is the Details action for product with ID: {id}");
        }

        public IActionResult Create()
        {
            return Content("This is the Create action.");
        }

        public IActionResult Edit(int id)
        {
            return Content($"This is the Edit action for product with ID: {id}");
        }

        public IActionResult Delete(int id)
        {
            return Content($"This is the Delete action for product with ID: {id}");
        }
    }
}
