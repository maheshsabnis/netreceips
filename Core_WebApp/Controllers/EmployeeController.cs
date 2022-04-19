using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
using Core_WebApp.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using Core_WebApp.CustomSession;
using Microsoft.AspNetCore.Authorization;

namespace Core_WebApp.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private IService<Employee, int> empService;
        private readonly IService<Department, int> deptService;

        public EmployeeController(IService<Employee, int> serv, IService<Department, int> serv1)
        {
            empService = serv;
            deptService = serv1;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> res;

            // read DeptNo from Session
            int DeptNo = Convert.ToInt32( HttpContext.Session.GetInt32("DeptNo"));
            // read the Dept object from the session
            var dept = HttpContext.Session.GetObject<Department>("Dept");
            if (DeptNo == 0)
            {
                res = empService.GetAsync().Result;
            }
            else
            { 
              res = empService.GetAsync().Result.Where(e=>e.DeptNo == DeptNo);
            }
            return View(res);
        }

        public IActionResult Create()
        {
            var emp = new Employee();
            List<SelectListItem> depts = new List<SelectListItem>();
            foreach (var d in deptService.GetAsync().Result.ToList())
            {
                depts.Add(new SelectListItem(d.DeptName, d.DeptNo.ToString()));
            }
            // ViewBag.DeptNo = new SelectList(depts, "DeptNo", "DeptName");
            ViewBag.DeptNo = depts;
            return View(emp);
        }
        [HttpPost]
        public IActionResult Create(Employee Employee)
        {
            // if no error then Process values
            if (ModelState.IsValid)
            {
                var res = empService.CreateAsync(Employee).Result;
                return RedirectToAction("Index");
            }
            else
            {
                List<SelectListItem> depts = new List<SelectListItem>();
                foreach (var d in deptService.GetAsync().Result.ToList())
                {
                    depts.Add(new SelectListItem(d.DeptName, d.DeptNo.ToString()));
                }
                // ViewBag.DeptNo = new SelectList(depts, "DeptNo", "DeptName");
                ViewBag.DeptNo = depts;
                //Stay on the same page
                return View(Employee);
            }

        }
        public IActionResult ValidateEmpNo(int EmpNo)
        {
            var emp = empService.GetAsync(EmpNo).Result;
            if (emp != null)
                return Json(data: "EmpNo is already present");

            return Json(data: true);
        }

        /// <summary>
        /// The Http Get Edit Request MUST pass the
        /// Roote Parameter as 'id' (Refer: app.USeEndpoint() in Configure() method of Startup.cs)
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            var res = empService.GetAsync(id).Result;
            // return a view that will show the record to be edited
            return View(res);
        }

        /// <summary>
        /// Edit the record with Post request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Employee"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(int id, Employee Employee)
        {
            var res = empService.UpdateAsync(id, Employee).Result;
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Http Get Request that will accept an id of record to delete 
        /// and return a veiw that will show the record to be deleted
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            var res = empService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Delete(int id, Employee Employee)
        {
            var res = empService.DeleteAsync(id).Result;
            return RedirectToAction("Index");
        }
    }
}
