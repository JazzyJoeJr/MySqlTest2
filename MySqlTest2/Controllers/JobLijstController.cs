using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySqlTest2.Models;
using MySqlTest2.DataManagers;

namespace MySqlTest2.Controllers
{
    public class JobLijstController : Controller
    {
        // GET: JobLijst
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult JobLijst(string naam)
        {
            var mod = new JobLijstViewModel();
            var jobsData = new JobDataManager();
            mod.StitchJobs = jobsData.GetJobsStitch();
            return View(mod);
        }

       
    }
}