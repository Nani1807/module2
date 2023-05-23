using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.WebHost;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Module2
{
    public class EmployeeController : Controller
    {
        // GET: Employee/HireEmployee
        public ActionResult HireEmployee()
        {
            return View();
        }

        // POST: Employee/HireEmployee
        [HttpPost]
        public ActionResult HireEmployee(Employee employee)
        {
            // Ваш код для обробки даних працівника
            // Наприклад, збереження в базі даних

            // При потребі можна встановити повідомлення про успішний прийом на роботу
            ViewBag.SuccessMessage = "Employee hired successfully.";

            return View();
        }
    }

}