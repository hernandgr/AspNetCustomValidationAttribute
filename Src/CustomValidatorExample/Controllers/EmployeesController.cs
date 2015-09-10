using CustomValidatorExample.Models;
using System.Web.Mvc;

namespace CustomValidatorExample.Controllers
{
    public class EmployeesController : Controller
    {
        public ViewResult Index()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ViewResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // ...
            }

            return View(employee);
        }
    }
}