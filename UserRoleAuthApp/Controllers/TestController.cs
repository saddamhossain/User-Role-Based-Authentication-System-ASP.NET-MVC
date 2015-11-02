using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRoleAuthApp.Controllers
{
    [Authorize(Roles = "Admin, Manager")]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Test1()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Test2()
        {
            return View();
        }


    }
}