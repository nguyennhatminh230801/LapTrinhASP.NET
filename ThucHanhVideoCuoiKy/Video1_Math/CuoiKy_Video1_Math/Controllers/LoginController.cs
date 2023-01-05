using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuoiKy_Video1_Math.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string UserLogin(string username, string password)
        {
            string result = "";

            if(username == password)
            {
                result = "Login success, hello " + username;
            } else
            {
                result = "Invalid username or password";
            }

            return result;
        }
    }
}