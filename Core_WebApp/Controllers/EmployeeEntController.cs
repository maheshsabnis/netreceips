using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
namespace Core_WebApp.Controllers
{
    public class EmployeeEntController : Controller
    {
        EmployeeEnts employees;

        public EmployeeEntController()
        {
            employees = new EmployeeEnts(); 
        }
        public IActionResult Index()
        {
            // Passing a Collection
            return View(employees);
        }

        /// <summary>
        /// The Http Get method to Return a view with
        /// EMpty UI for Accepting EmployeeEnt data
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            // pass an EMpty Object
            return View(new EmployeeEnt());
        }
        [HttpPost] // The Post method executed fr FOrm Submit
        public IActionResult Create(EmployeeEnt emp)
        {
            // Add posted data from UI to collection
            employees.Add(emp);
            // redirect to the Indx method
            return RedirectToAction("Index");
        }
    }
}
