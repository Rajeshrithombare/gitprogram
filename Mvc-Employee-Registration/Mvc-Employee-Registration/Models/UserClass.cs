using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Employee_Registration.Models
{
     public class UserClass
     {
        

        [Required(ErrorMessage ="Enter Employee Name")]
        [Display(Name ="Enter Employee name")]
        [StringLength(maximumLength:20, MinimumLength =10,ErrorMessage ="Please enter Employee Fiest name and Last name")]
        public string EmployeeName { get; set; }

       


        [Required(ErrorMessage ="Salary Field can not be blank")]
        [Display(Name ="Enter Salary")]
        public string Salary { get; set; }


        [Required(ErrorMessage = "Address Field can not be blank")]
        [Display(Name = "Enter Address")]
        public string Address { get; set; }



        [Required(ErrorMessage = "Enter Email id")]
        [Display(Name = "Enter Email")]
        public string Email_id { get; set; }


        [Required(ErrorMessage = "Enter Password")]
        [Display(Name = "Enter Password")]
        [DataType(DataType.Password)]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format")]
        public string Password { get; set; }


        [Required(ErrorMessage = "ReEnter Password")]
        [Display(Name = "ReEnter Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Re_Enter_Password { get; set; }


        [Required(ErrorMessage = "Date Field can not be blank")]
        [Display(Name = "Enter Joining Date")]
        [DataType(DataType.Date)]
        public string Date_of_join { get; set; }



        [Required(ErrorMessage = "Select hobbies")]
        [Display(Name = "Select Hobbies")]
        public Hobbi Hobbies { get; set; }


       
        public string hobbie { get; set;}



        [Required(ErrorMessage = "Select Genger")]
        [Display(Name = "Select gender")]
        public string Gender { get; set; }



        [Required(ErrorMessage = "Select State")]
        [Display(Name = "Select State")]
        public string State { get; set; }



        [Required(ErrorMessage = "Select City")]
        [Display(Name = "Select City")]

        public string City { get; set; }



       public enum Hobbi{ Cricet, Dancing, Singing, Drawing }
     }
}