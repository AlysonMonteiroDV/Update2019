using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list = new List<Departments>();
            list.Add(new Departments { id = 1, Name = "Eletronics"});
            list.Add(new Departments { id = 2, Name = "Fashion"});


            return View(list);
        }
    }
}
