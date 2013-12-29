using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Site.Models.SystemUser user)
        {
            return View();
        }

    }
}
