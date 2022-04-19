using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core_WebApp.Controllers
{
    public class CategoryClientController : Controller
    {
        HttpClient client;
        public CategoryClientController()
        {
            client = new HttpClient();
        }
        public async Task<IActionResult> Index()
        {
            var cats = await client.GetFromJsonAsync<List<Category>>("https://localhost:7013/api/Category");
            return View(cats);
        }

        public IActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            
            var response = await client.PostAsJsonAsync<Category>("https://localhost:7013/api/Category", category);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No Succes";
                return View(category);
            }
            
        }
    }
}
