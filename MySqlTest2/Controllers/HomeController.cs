using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySqlTest2.Models;
using MySql.Data.MySqlClient;
using MySqlTest2.DataManagers;
namespace MySqlTest2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}