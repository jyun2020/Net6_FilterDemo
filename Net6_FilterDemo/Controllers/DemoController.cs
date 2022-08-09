using Microsoft.AspNetCore.Mvc;
using Net6_FilterDemo.Filters;

namespace Net6_FilterDemo.Controllers
{
    public class DemoController : Controller
    {
        public DemoController()
        {
            Console.WriteLine("DemoController建構子");
        }
        public IActionResult Index()
        {
            return View();
        }

        [CustomResourceFilter]
        public IActionResult Resource()
        {
            Console.WriteLine("進入Action");
            return View();
        }
    }
}
