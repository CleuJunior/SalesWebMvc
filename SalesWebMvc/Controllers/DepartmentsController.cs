using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletronics" }); 
            departments.Add(new Department { Id = 2, Name = "Fashino" });
            departments.Add(new Department { Id = 3, Name = "Geek" });
            departments.Add(new Department { Id = 4, Name = "Cinematic" });

            return View(departments);
        }
    }
}
