using Microsoft.AspNetCore.Mvc;

namespace BudgetWebUI.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
