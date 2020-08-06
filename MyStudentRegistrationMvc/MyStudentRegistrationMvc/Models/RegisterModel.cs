using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStudentRegistrationMvc.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
        public string Emaile { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public string Cource { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string Date_Of_Birth { get; set; }
    }
}