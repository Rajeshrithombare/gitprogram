using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace BookStoretestOnMVC.Models
{
    public class LoginClass
    {
        [Required(ErrorMessage ="Please enter Your Email")]
        [Display(Name ="Enter Email")]
        [DataType(DataType.EmailAddress)]
        public string Email_id { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        [Display(Name ="Enter Password ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [Display(Name = "ReEnter Password ")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}