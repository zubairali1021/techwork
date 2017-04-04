using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult signup()
        {
            return View();
        }

	}
}