using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
using Core_WebApp.Services;
using System.Linq;

namespace Core_WebApp.Controllers
{
    public class DeptEmpListsController : Controller
    {
        private readonly IService<Department, int> deptServ;
        private readonly IService<Employee, int> empServ;
        public DeptEmpListsController(IService<Department, int> deptServ, IService<Employee, int> empServ)
        {
            this.deptServ = deptServ;
            this.empServ = empServ;
        }
        /// <summary>
        /// Lets Moify the Index Action with the id parameter
        /// But initialliy we need to show all depts and emps
        /// so the initial value of 'id' must be 0
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(int id = 0)
        {
            var deptEmps = new DeptEmpLists();
            deptEmps.Departments = deptServ.GetAsync().Result.ToList();
            if (id == 0)
            {
                deptEmps.Employees = empServ.GetAsync().Result.ToList();
            }
            else 
            {
                deptEmps.Employees = empServ.GetAsync().Result.Where(e=>e.DeptNo == id).ToList();
            }
           
            return View(deptEmps);
        }

        public IActionResult ShowEmps(int id)
        {
            // return to Index View with a Route Parameter
            return RedirectToAction("Index", new { id = id});
        }
    }
}
