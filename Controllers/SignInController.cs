using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamA_Project.Models;


namespace WebApplication23.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        [HttpGet]
        public ActionResult SignIn()
        {
            return View(new SignIn());
        }

        public ActionResult SignIn(SignIn objSign)
        {
            if (!ModelState.IsValid)
            {
                return View(objSign);
            }
            else
            {
                if ((objSign.UserName == "sam777") && (objSign.UserPwd == "sam1234"))
                {
                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid");
                    return View(objSign);
                }



            }
        }



    }
}