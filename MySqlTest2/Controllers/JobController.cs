using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySqlTest2.Models;
using MySqlTest2.DataManagers;

namespace MySqlTest2.Controllers
{
    public class JobController : Controller
    {
        // GET: JobLijst
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult JobLijst()
        {
            var mod = new JobViewModel();
            var jobsData = new JobDataManager();
            mod.StitchJobs = jobsData.GetJobsStitch();
            mod.StichJobsbyMachineId1 = jobsData.GetJobsStitchByMachineId(1);
            mod.StichJobsbyMachineId2 = jobsData.GetJobsStitchByMachineId(2);
            mod.StichJobsbyMachineId3 = jobsData.GetJobsStitchByMachineId(3);
            mod.StichJobsbyMachineId4 = jobsData.GetJobsStitchByMachineId(4);
            mod.StitchJobsbyMachineId0 = jobsData.GetJobsStitchByMachineId(0);
            return View(mod);
        }
        public ViewResult PlanJob(int Id, string MachineId)
        {
            var jobsData = new JobDataManager();
            ViewBag.RowsAffected = jobsData.SetJobMachineIdById(Id);
            return View();
        }

       
    }
}