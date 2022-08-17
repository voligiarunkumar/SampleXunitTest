using Microsoft.AspNetCore.Mvc;

namespace LMS.Web.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class MyFirstDemoController : Controller
    {
        // GET https://localhost:44386/demos/myfirstdemo
        // GET https://localhost:44386/demos/myfirstdemo/index
        // url / {area} / {controller} / {action}
        public IActionResult Index()
        {
            return Ok("hello world");
        }

        // GET https://localhost:44386/demos/myfirstdemo/index2
        public IActionResult Index2()
        {
            return View();
        }
    }
}
