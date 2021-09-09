using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class WebUserController : Controller
    {
        // GET: WebUser
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(WebUserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou", model);
            }
            return View(model);
        }

        public ActionResult ThankYou(WebUserModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}