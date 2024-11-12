using Microsoft.AspNetCore.Mvc;
using ST10291238_CLDV6212_POE.Models;

namespace ST10291238_CLDV6212_POE.Controllers
{
    public class ProductController : Controller
    {
        public ProductTable prdtbl = new ProductTable();
        public OrdersTable ordertbl = new OrdersTable();

        [HttpPost]
        public ActionResult Product(ProductTable p, OrdersTable o)
        {
            prdtbl.insert_Product(p);
            ordertbl.insert_order(o);
            return RedirectToAction("Products", "Home");
        }
    }
}
