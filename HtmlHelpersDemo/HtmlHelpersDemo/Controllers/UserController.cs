using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersDemo.Models;
namespace HtmlHelpersDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            LoadContries();
            return View();
        }

        [NonAction]
        public void LoadContries()
        {
            var countries = new List<SelectListItem>
                    {
                new SelectListItem{Value="India",Text="India" },
                new SelectListItem{Value="U.S.",Text="U.S." },
                new SelectListItem{Value="China",Text="China" }
                };
            ViewBag.country = countries;
        }

        [HttpPost]
        public ActionResult Save(Register register)
        {
            if (register.Terms)
            {
                // Your save logic goes here
                return Content("Registered Successfully");
            }
            else
            {
                ViewBag.msg = "You have to agreed upon Terms";
                LoadContries();
                return View("Register");
            }
        }
    }
}