using Microsoft.AspNetCore.Mvc;

namespace BudgetWebUI.Controllers
{
    public class BudgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
