using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
using Core_WebApp.Services;
using System;
using Core_WebApp.CustomFilters;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Http;
using Core_WebApp.CustomSession;
using Microsoft.AspNetCore.Authorization;

namespace Core_WebApp.Controllers
{
    /// <summary>
    /// Apply Filter at Controller
    /// </summary>
    /// 
   // [LogFilter]
    public class DepartmentController : Controller
    {
        private readonly IService<Department, int> deptService;
        /// <summary>
        /// Inject the IService<Departement,int> aka DepartmentService in it
        /// </summary>
        public DepartmentController(IService<Department, int> service)
        {
            deptService = service;
        }
        /// <summary>
        /// Applying Custom Filter on Action
        /// </summary>
        /// <returns></returns>
        // [LogFilter]
        //[Authorize(Roles = "Manager,Clerk,Operator")]
        [Authorize(Policy = "ReadPolicy")]
        public IActionResult Index()
        {
            var res = deptService.GetAsync().Result;
            return View(res);
        }
        /// <summary>
        /// Securing Actions
        /// </summary>
        /// <returns></returns>
        //[Authorize(Roles = "Manager,Clerk")]
        [Authorize(Policy = "ManagerClerkPolicy")]
        public IActionResult Create()
        {
            var dept = new Department();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            //try
            //{
               

                // if no error then Process values
                if (ModelState.IsValid)
                {
                    // USe if-else statements for Explict Model Validations
                    var dept = deptService.GetAsync(department.DeptNo).Result;
                    if (dept != null)
                    {
                        throw new Exception($"Department No {department.DeptNo} is already present");
                    }
                Department newDepartment = new Department();
                    var res = deptService.CreateAsync(department).Result;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewData["Message"] = "Kay Yaar again Wrong Data!!!!";
                    ViewBag.NewMessage = "Ram Bhala Kare";
                    //Stay on the same page
                    return View(department);
                }
            //}
            //catch (Exception ex)
            //{
            //    // Return the Error Page
            //    //return View("Error", new ErrorViewModel() 
            //    //{
            //    //   ControllerName = "Department",
            //    //   ActionName = "Create",
            //    //   ErrorMessage = ex.Message
            //    //});

            //    return View("Error", new ErrorViewModel()
            //    {
            //        ControllerName = RouteData.Values["controller"].ToString(),
            //        ActionName = RouteData.Values["action"].ToString(),
            //        ErrorMessage = ex.Message
            //    });

            //}
            
        }

        /// <summary>
        /// The Parameter Name MUST match with the NAme of the HTML element
        /// from whih value will be used for Async POst
        /// </summary>
        /// <param name="DeptNo"></param>
        /// <returns></returns>
        public IActionResult ValidateDeptNoUnique(int DeptNo)
        {
            var dept = deptService.GetAsync(DeptNo).Result;
            if (dept != null)
                return Json(false); // invalid
            return Json(true); // Valid 
        }





        /// <summary>
        /// The Http Get Edit Request MUST pass the
        /// Roote Parameter as 'id' (Refer: app.USeEndpoint() in Configure() method of Startup.cs)
        /// </summary>
        /// <returns></returns>
        /// 
        // [Authorize(Roles = "Manager,Clerk")]
        [Authorize(Policy = "ManagerClerkPolicy")]
        public IActionResult Edit(int id)
        {
            var res = deptService.GetAsync(id).Result;
            // return a view that will show the record to be edited
            return View(res);
        }

        /// <summary>
        /// Edit the record with Post request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="department"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(int id, Department department)
        { 
            var res = deptService.UpdateAsync(id, department).Result;
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Http Get Request that will accept an id of record to delete 
        /// and return a veiw that will show the record to be deleted
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        // [Authorize(Roles = "Manager")]
        [Authorize(Policy = "ManagerPolicy")]
        public IActionResult Delete(int id)
        {
            var res = deptService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Delete(int id, Department department)
        {
            var res = deptService.DeleteAsync(id).Result;
            return RedirectToAction("Index");
        }
        public IActionResult ShowEmployees(int id)
        {
            // Save DeptNo in session
            HttpContext.Session.SetInt32("DeptNo",id);
            // Get the department objet based on id
            var dept = deptService.GetAsync(id).Result;
            // Save the object in session

            HttpContext.Session.SetObject<Department>("Dept", dept);

            return RedirectToAction("Index", "Employee");
        }


        public IActionResult ShowDeptRecords()
        {
            var res = deptService.GetAsync().Result;
            return View(res);
        }

        public IActionResult IndexHelper()
        {
            var res = deptService.GetAsync().Result;
            return View(res);
        }

        public IActionResult CollectionHelper()
        {
            var res = deptService.GetAsync().Result;
            return View(res);
        }
    }
}
