using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobsYouveHeld.Models;

namespace JobsYouveHeld.Controllers
{
    public class JobsController : Controller
    {

        [HttpGet("/Jobs")]
        public ActionResult Index()
        {
            List<Jobs> allJobs = Jobs.GetAll();
            return View(allJobs);
        }

        [HttpGet("/Jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/Jobs")]
        public ActionResult Create()
        {
          Jobs newJobs = new Jobs(Request.Form["Job"],Request.Form["StartDate"],Request.Form["EndDate"]);
          newJobs.Save();
          List<Jobs> allJobs = Jobs.GetAll();
          return View("Index", allJobs);
          // return RedirectToAction("Index");
        }

        [HttpPost("/Jobs/delete")]
        public ActionResult DeleteAll()
        {
            Jobs.ClearAll();
            return View();
        }

    }
}
