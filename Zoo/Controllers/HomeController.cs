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
            //insert code here to validate log in
            return View();
        }//end Index

        public ActionResult ViewEmployeeSchedule()
        {
            //code to display a single employee's schedule
            return View();
        }//end ViewEmployeeSchedule

        public ActionResult ChooseDepartmentToManage()
        {
            return View();
        }//end ChooseDepartmentToManage

        public ActionResult ChooseManagementTask()
        {
            return View();

        }//end ChooseManagementTask

        public ActionResult ChooseCreateWeek()
        {
            return View();

        }//end ChooseWeek

        public ActionResult CreateDepartmentSchedule()
        {
            return View();

        }//end CreateDepartmentSchedule

        public ActionResult ChooseViewWeek()
        {
            return View();

        }//end ChooseViewWeek

        public ActionResult ViewDepartmentSchedule()
        {
            return View();

        }//end ViewDepartmentSchedule

        public ActionResult ChooseEditWeek()
        {
            return View();

        }//end ChooseEditWeek

        public ActionResult EditDepartmentSchedule()
        {
            return View();

        }//end EditDepartmentSchedule



    }//end controller
}//end namespace

     