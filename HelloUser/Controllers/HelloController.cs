using HelloUser.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HelloUser.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet, Route("Home/Index"), Route("")]
        public IActionResult Index(NameModel User)
        {
            return View("~/Views/Home/Index.cshtml", User);
        }
        [HttpPost]
        public IActionResult Hello(NameModel HelloUser)
        {
            return View("~/Views/Home/Hello.cshtml", HelloUser);
        }

    }
}
