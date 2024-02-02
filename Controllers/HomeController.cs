using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simple_Static_Website.Models;

namespace Simple_Static_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("LoginForm");
        }

        [HttpGet]
        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginForm(LoginViewModel lvm)
        {
            if (ModelState.IsValid == false) //repsponse is not valid
            {
                return View(lvm);
            }

            if (lvm.Password != "Bevo" || lvm.Agree != true) //password is incorrect
            {
                return View(lvm);
            }

            //Return the Harry Potter world view
            return View("Welcome", lvm.House);
        }
    }
}

