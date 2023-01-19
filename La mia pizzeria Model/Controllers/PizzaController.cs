using Microsoft.AspNetCore.Mvc;

namespace La_mia_pizzeria_Model.Controllers {
    public class PizzaController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
