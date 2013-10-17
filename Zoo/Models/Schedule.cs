using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoo.Models
{
    public class Schedule
    {
        public string EmployeeID { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
    }
}