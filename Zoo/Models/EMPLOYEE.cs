using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoo.Models
{
    public class Employee
    {
        public string Employee_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name {get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}