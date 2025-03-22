using FormAndLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormAndLayout.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(MyClass m)
        {
            // Check if DOB is provided and the user is over 18
            if (m.DOB.HasValue)
            {
                var age = DateTime.Now.Year - m.DOB.Value.Year;
                if (m.DOB.Value.Date > DateTime.Now.AddYears(-age)) age--;  // Adjust for birthday

                if (age < 18)
                {
                    ModelState.AddModelError("DOB", "You must be at least 18 years old.");
                }
            }

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index", "New");
            }


            return View(m);
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View(new MyClass());
        }
        [HttpPost]
        public ActionResult Login(MyClass m) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "New");
            }
            return View(m);

        }

    }
}