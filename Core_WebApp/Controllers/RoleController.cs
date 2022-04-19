using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Core_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Core_WebApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager; 
        }

        public async Task<IActionResult> Index()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                var result = await roleManager.CreateAsync(role);
                return RedirectToAction("Index");
            }
            else
            { 
                return View(role);
            }
        }

        public async  Task<IActionResult> AssignRole()
        {
            ViewBag.Users = new SelectList(await userManager.Users.ToListAsync(), "Id", "Email");
            ViewBag.Roles = new SelectList(await roleManager.Roles.ToListAsync(), "Id", "Name");
            return View(new UserInRole());

        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(UserInRole userInRole )
        {
            ViewBag.Users = new SelectList(await userManager.Users.ToListAsync(), "Id", "Email");
            ViewBag.Roles = new SelectList(await roleManager.Roles.ToListAsync(), "Id", "Name");
            // 1. Check if the USer is Present
            var user = await userManager.FindByIdAsync(userInRole.UserId);
            if (user == null)
            {
                ViewBag.Message = "Sorry This User is Not Present";
                return View(userInRole);
            }
            // 2. Check if the Role os Present
            var role = await roleManager.FindByIdAsync(userInRole.RoleId);
            if (role == null)
            {
                ViewBag.Message = "Sorry This Role is Not Present";
                return View(userInRole);
            }

            var result = await userManager.AddToRoleAsync(user, role.Name);
            ViewBag.Message = $"User {user.Email} is successfully is assigned to Role {role.Name}";
            return View(userInRole);
        }
    }
}
