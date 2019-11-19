using Microsoft.AspNetCore.Mvc;

namespace RedisTest.Controllers
{
    public class HomeController : Controller
    {
        private IService.IStackExchange<string> _stackExchange;
        public HomeController(IService.IStackExchange<string> stackExchange)
        {
            _stackExchange = stackExchange;
        }

        public IActionResult Index()
        {
            _stackExchange.InsertValue("Token", "token_1");
            var result = _stackExchange.GetByValue("Token");
            _stackExchange.DeleteValue("Token");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
