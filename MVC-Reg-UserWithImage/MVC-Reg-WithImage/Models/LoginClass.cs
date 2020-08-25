using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Reg_UserExample.Models
{
    public class LoginClass
    {
        [Required(ErrorMessage ="Plese enter your Email")]
        [Display(Name ="Enter Email :")]
        public string Email_id { get; set; }

        [Required(ErrorMessage = "Plese enter your Password")]
        [Display(Name = "Enter Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}