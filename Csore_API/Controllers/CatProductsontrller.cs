using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Csore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatProductsController : ControllerBase
    {
        private readonly IService<Category, int> catServ;
        private readonly IService<Product, int> prdServ;

        public CatProductsController(IService<Category, int> catServ, IService<Product, int> prdServ)
        {
            this.catServ = catServ;
            this.prdServ = prdServ;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CatProducts data)
        {
            var res = await catServ.CreateAsync(data.Category);
            foreach (var item in data.Products)
            {
                await prdServ.CreateAsync(item);
            }
            return Ok("Done Dana Done");
        }
    }
}
