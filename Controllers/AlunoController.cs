using Microsoft.AspNetCore.Mvc;

namespace TesteCrudProfessoresAlunos.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
