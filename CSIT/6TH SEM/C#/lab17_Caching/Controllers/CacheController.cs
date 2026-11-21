using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace lab17caching.Controllers
{
    public class CacheController : Controller
    {
        private readonly IMemoryCache _cache;

        public CacheController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            string cacheKey = "CurrentTime";

            if (!_cache.TryGetValue(cacheKey, out string cachedTime))
            {
                // Not in cache -> generate and store it
                cachedTime = DateTime.Now.ToString("HH:mm:ss");

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));

                _cache.Set(cacheKey, cachedTime, cacheOptions);
                ViewBag.Source = "Generated Fresh";
            }
            else
            {
                ViewBag.Source = "Fetched From Cache";
            }

            ViewBag.Time = cachedTime;
            return View();
        }

    }
}
