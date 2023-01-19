using Microsoft.AspNetCore.Mvc;

namespace La_mia_pizzeria_Model.Models {
    public class Pizza : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
