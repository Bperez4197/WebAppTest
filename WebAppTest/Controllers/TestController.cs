using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(TestModel model)
        {
            if (ModelState.IsValid)
            {
                int result = 0;

                if (model.OperationType == "Add")
                {
                    result = model.FirstNumber + model.SecondNumber;
                }
                else if (model.OperationType == "Subtract")
                {
                    result = model.FirstNumber - model.SecondNumber;
                }
                else if (model.OperationType == "Multiply")
                {
                    result = model.FirstNumber * model.SecondNumber;
                }
                else if (model.OperationType == "Divide")
                {
                    result = model.FirstNumber / model.SecondNumber;
                }
                TestResultModel resultModel = new TestResultModel();
                resultModel.Result = result;

                return RedirectToAction("DisplayResult", resultModel);
            }
            return View(model);
        }



        public ActionResult DisplayResult(TestResultModel model)
        {
            return View(model);
        }
    }
}