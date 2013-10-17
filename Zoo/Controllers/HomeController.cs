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

        public ActionResult  ChooseDepartmentToManage()
        {
            return View();
        }//end ChooseDepartmentToManage

        public ActionResult ChooseManagementTask()
        {
            return View();

        }//end ChooseManagementTask

        public ActionResult CreateDepartmentSchedule()
        {
            return View();

        }//end CreateDepartmentSchedule

        public ActionResult ViewDepartmentSchedule()
        {
            return View();

        }//end ViewDepartmentSchedule

        public ActionResult EditDepartmentSchedule()
        {
            return View();

        }//end EditDepartmentSchedule

    }//end controller
}//end namespace

     