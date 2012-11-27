using MVC4WithFormsAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4WithFormsAuthentication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Register()
        {
            return View(new Registration());
        }

    }
}
