using Microsoft.AspNetCore.Mvc;

namespace MvcPlants.Controllers
{
    public class PlantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
