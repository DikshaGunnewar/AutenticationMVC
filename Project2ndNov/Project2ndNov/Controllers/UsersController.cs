using Project2ndNov.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2ndNov.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        [AuthLog(Roles = "User")]
        public ActionResult Index()
        {
            return View();
        }
    }
}