using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySqlTest2.Models;
using MySqlTest2.DataManagers;
using System.IO;

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
        public ViewResult PlanJob(int Id, int MachineId)
        {
            var jobsData = new JobDataManager();
            ViewBag.RowsAffected = jobsData.SetJobMachineIdById(Id, MachineId);
            return View();
        }
        public ViewResult JobLezer()
        {
            List<JobStitch> jobs = new List<JobStitch>();
            StreamReader lezer = new StreamReader("C:\\Users\\Jo\\Documents\\AProject\\MySqlTest2\\bin\\myCsv.txt");
            string lijn = lezer.ReadLine();

            while (!lezer.EndOfStream)
            {
                lijn = lezer.ReadLine();
                string[] splits = lijn.Split(';');
                JobStitch stitch = new JobStitch();
                stitch.LeverDatum = Convert.ToDateTime(splits[4]);
                stitch.JobNr = splits[1];

                double aantal = double.Parse(splits[2]);
                stitch.Aantal = Convert.ToInt16(aantal);
               
               
                stitch.Breedte = 210;
                stitch.Hoogte = 297;
                stitch.Cover = false;
                stitch.AantalBlz = 8;
                stitch.PapierBw = "mc-silk 130";

                jobs.Add(stitch);

            }

            return View();
        }

       
    }
}