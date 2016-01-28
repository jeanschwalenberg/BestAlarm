using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestAlarm.Models;

namespace BestAlarm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult UserMaker() {
            User babyUser = new User() {

            }
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}