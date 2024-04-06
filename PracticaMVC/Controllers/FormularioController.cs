using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
