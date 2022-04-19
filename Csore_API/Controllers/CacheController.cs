using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Csore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private readonly IDistributedCache distributedCache;
        private ApiDbContext context;

        public CacheController(ApiDbContext context, IDistributedCache distributedCache)
        {
            this.distributedCache = distributedCache;   
            this.context = context; 
        }


        [HttpGet]
        public IActionResult Get()
        {
            // chec if the cache with name 'categories' is present
            string categoriesData = distributedCache.GetString("categories");
            if (categoriesData == null)
            {
                // if the cache is null then add data in cache 
                // Get data from Database
                List<Category> categories = context.Categories.ToList();
                // serialize data in JSON Form
                categoriesData = JsonSerializer.Serialize<List<Category>>(categories);
                // save data in cache
                // DistributedCacheEntryOptions: class used to define caching metadata e.g. life span for cache

                var cacheOptions = new DistributedCacheEntryOptions();
                // expiration time from the Cache Time
                cacheOptions.SetAbsoluteExpiration(DateTimeOffset.Now.AddMinutes(1));
                // Save Data into the Cache
                distributedCache.SetString("categories", categoriesData, cacheOptions);
                return Ok(new
                {
                    message = "Data Received from Database",
                    data = categories
                });
            }
            else
            {
                // read data from cache and return it
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                // deserilized the data from cache
                List<Category> cats = JsonSerializer.Deserialize<List<Category>>(categoriesData, options);
                // return dara from cache
                return Ok(new
                {
                    message = "Data Received from Cache",
                    data = cats
                });
            }

        }
    }
}
