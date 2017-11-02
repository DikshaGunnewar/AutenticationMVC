using Project2ndNov.CustomFilters;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2ndNov.Controllers
{
    public class AdminController : Controller
    {
        [AuthLog(Roles ="Admin")]
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}