using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Csore_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IService<Category, int> catServ;
        private readonly IService<Product,int> prdServ  ;

        public SearchController(IService<Category, int> catServ, IService<Product, int> prdServ)
        {
            this.catServ = catServ;
            this.prdServ = prdServ;
        }

        [HttpGet("{catname}")]
        [ActionName("searchdata")]
        public IActionResult SearchData(string catname)
        {
            List<Product> products = new List<Product>();   
            Category cat = catServ.GetAsync().Result.Where(c => c.CategoryName == catname).FirstOrDefault();
            if (cat != null)
            {
                if (cat.CategoryRowId != 0)
                {
                    products = prdServ.GetAsync().Result.ToList();

                    var result = from prd in products
                                 where prd.CategoryRowId == cat.CategoryRowId
                                 select new Product()
                                 {
                                     ProductRowId = prd.CategoryRowId,
                                     ProductId = prd.ProductId,
                                     ProductName = prd.ProductName,
                                     Description = prd.Description
                                 };
                    if (result.Count() > 0)
                    {
                        return Ok(result);
                    }
                    return Ok($"No Products for Category Name {catname}");
                }
                else
                {
                    return Ok($"No Products for Category Name {catname}");
                }
            }
            else
            {
                return BadRequest("Please provide Correct Caregory NAme");
            }
           

        }



        [HttpGet("{catname}")]
        [ActionName("searchcomplex")]
        public IActionResult SearchComlex(string catname)
        {
            List<Product> products = new List<Product>();
            Category cat = catServ.GetAsync().Result.Where(c => c.CategoryName == catname).FirstOrDefault();
            if (cat != null)
            {
                if (cat.CategoryRowId != 0)
                {
                    products = prdServ.GetAsync().Result.ToList();

                    var result = from prd in products
                                 where prd.CategoryRowId == cat.CategoryRowId
                                 select new 
                                 {
                                     ProductRowId = prd.CategoryRowId,
                                     ProductId = prd.ProductId,
                                     ProductName = prd.ProductName,
                                     Description = prd.Description,
                                     Categoryame = cat.CategoryName,
                                     BasePrice = cat.BasePrice,
                                     CategoryId=cat.CategoryId
                                 };
                    if (result.Count() > 0)
                    {
                        return Ok(result);
                    }
                    return Ok($"No Products for Category Name {catname}");
                }
                else
                {
                    return Ok($"No Products for Category Name {catname}");
                }
            }
            else
            {
                return BadRequest("Please provide Correct Caregory NAme");
            }


        }


        [HttpGet("{catname}/{condition}/{prdname}")]
        [ActionName("searchcomplex")]
        public IActionResult SearchCondition(string catname, string condition, string prdname)
        {
            List<Product> products = new List<Product>();
            Category cat = catServ.GetAsync().Result.Where(c => c.CategoryName == catname).FirstOrDefault();
            switch (condition)
            {
                case "AND":
                    products = (from prd in prdServ.GetAsync().Result.ToList()
                               where prd.CategoryRowId == cat.CategoryRowId && prd.ProductName ==       prdname
                               select prd).ToList();
                    break;
                case "OR":
                    products = (from prd in prdServ.GetAsync().Result.ToList()
                                where prd.CategoryRowId == cat.CategoryRowId || prd.ProductName == prdname
                                select prd).ToList();
                    break;
                default:
                    products = new List<Product>();
                    break;
            }
            return Ok(products);
        }
    }
}
