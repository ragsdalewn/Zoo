using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zoo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }//end Index

        public ActionResult ViewEmployeeSchedule()
        {

            return View();
        }//end ViewEmployeeSchedule

    }//end controller
}//end namespace

     