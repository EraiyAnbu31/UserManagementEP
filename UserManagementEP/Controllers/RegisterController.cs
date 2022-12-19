using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserManagementEP.Controllers
{
    public class RegisterController : Controller
    {
        // GET: RegUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegUser()
        {
            return View();
        }
    }
}