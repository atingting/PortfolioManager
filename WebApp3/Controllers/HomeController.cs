using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp3.Models;

namespace WebApp3.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        {
            var today = DateTime.Now.DayOfWeek;
            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                ViewBag.message = "weekend";
            }
            else {
                ViewBag.message = "work day";
            }
            return View("DefaultView");
        }

        public ActionResult SecondView()
        {
            return View();
        }

        public ActionResult ThirdView()
        {
            return View();
        }
        // Methods on controller are called Action
        //public string Index() {
        //    return "My new AVC app";
        //}
     

        [HttpGet]
        public ViewResult AddReview()
        {
           
            return View();
        }



        //[HttpPost]
        //public ViewResult AddReview(ChangeModel review)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        review.Submit();   // See next slide …
        //        AcceptModel m = new AcceptModel();
        //        m.getResult();
        //        return View("AcceptReview",m);
        //    }
        //    else
        //    {
        //        // Validation error, so re-display Review form.
        //        return View();
        //    }

        //}


        [HttpGet]
        public ViewResult AcceptReview(AcceptModel m)
        {
            m.getResult();
            return View();
        }

    }
}