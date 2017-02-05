using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySqlTest2.Models;
using MySqlTest2.DataManagers;

namespace MySqlTest2.Controllers
{
    public class JobInsertController : Controller
    {
        // GET: JobInsert
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult JobInsert(JobStitch job)
        {
            
            JobDataManager insert = new JobDataManager();
            ViewBag.RowsAffected = insert.InsertJobStitch(job);

            return View(job);
        }
    }
}