using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace BookStoretestOnMVC.Models
{
    public class BookUserClass
    {
        [Required(ErrorMessage ="Enter Book Name")]
        [Display(Name ="Book Name :")]

        public string BookName { get; set; }
        
        [Required(ErrorMessage ="Enter MRP Of Book")]
        [Display(Name ="Enter MRP :")]
        public string Mrp { get; set; }

        [Required(ErrorMessage = "Enter Author Name Of Book")]
        [Display(Name = "Enter Author Name :")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Enter Book Category")]
        [Display(Name = "Enter Book Category :")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Enter Publisher Name Of Book")]
        [Display(Name = "Enter Publisher Name :")]
        public string Publisher { get; set; }

        
    }
}