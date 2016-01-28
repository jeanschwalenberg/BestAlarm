using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestAlarm.Models;

namespace BestAlarm.Controllers {

    public class HomeController : Controller {

        // GET: Home
        //TODO thingy so passing User through Index() actually passes alarm table/array/whatever
        public ActionResult Index() {
            return View(User);
        }
    }
}