using Microsoft.AspNetCore.Mvc;
using ST10291238_CLDV6212_POE.Models;

namespace ST10291238_CLDV6212_POE.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerTable customerTable = new CustomerTable();

        [HttpPost]
        public ActionResult Index(CustomerTable c)
        {
            customerTable.insert_User(c);
            return RedirectToAction("Products", "Home");
        }
    }
}
