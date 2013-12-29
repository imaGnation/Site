using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{

    public class SystemUserController : Controller
    {

        private MainDBContext dba = new MainDBContext();
        //System User Registration
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Site.Models.SystemUser user)
        {
            return View();
        }


        //System User Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Site.Models.SystemUser user)
        {
            return View();
        }

        //System User Details Update
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Site.Models.SystemUser user)
        {
            return View();
        }

        //System User Acction Delete
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Site.Models.SystemUser user)
        {
            return View();
        }

        public bool IsValid(string email, string password)
        {
            bool isValid = false;
            var crypto = new SimpleCrypto.PBKDF2();
            using (var db = new MainDBContext())
            {
                var user = db.SystemUsers.FirstOrDefault(u => u.EmailAddress == email);
                if (user != null)
                {
                    if (user.Password == crypto.Compute(password, user.PasswordSalt))
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }

        public JsonResult IsUserNameAvailable(string Email_Address)
        {
            return Json(!dba.SystemUsers.Any(user => user.EmailAddress == Email_Address), JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsAvailableContact_No(string Contact_No)
        {
            return Json(!dba.SystemUsers.Any(user => user.ContactNo == Contact_No), JsonRequestBehavior.AllowGet);
        }

    }
}
