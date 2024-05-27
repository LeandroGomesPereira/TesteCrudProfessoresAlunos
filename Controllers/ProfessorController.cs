using Microsoft.AspNetCore.Mvc;

namespace TesteCrudProfessoresAlunos.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
