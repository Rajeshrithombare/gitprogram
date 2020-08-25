using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;


namespace MVC_Reg_UserExample.Models
{
    public class UserClass
    {

        public UserClass()
        {
            UserImage = null;
        }
        public UserClass(string un, string em, string pw, string ge, byte[] ui)
        {
            UserName = un;
            Email_id = em;
            Password = pw;
            Gender = ge;
            UserImage = ui;
        }
        [Required(ErrorMessage = "Enter User Name !")]
        [Display(Name = "Enter User Name :")]
        [StringLength(maximumLength: 12, MinimumLength = 3, ErrorMessage = "Username Length must be Max 7 & Min 3")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Plese enter the Email Address !")]
        [Display(Name = "Email id :")]
        public string Email_id { get; set; }


        [Required(ErrorMessage = "Enter the password !")]
        [Display(Name = "password :")]

        //[RegularExpression("([a-z][A-Z][0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}",ErrorMessage ="Password should be one capital later one small later one Number !")]
        //[RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$",ErrorMessage = "Password should be one capital later one small later one Number")]
        [DataType(DataType.Password)]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Enter the RePassword !")]
        [Display(Name = "Re-Password :")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }


        [Required(ErrorMessage = "Select the Gender !")]
        [Display(Name = "Gender :")]
        public string Gender { get; set; }


        public byte[] UserImage { get; set; }




    }
}