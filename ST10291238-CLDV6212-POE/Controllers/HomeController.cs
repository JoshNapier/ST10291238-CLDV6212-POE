using Microsoft.AspNetCore.Mvc;
using ST10291238_CLDV6212_POE.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ST10291238_CLDV6212_POE.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
