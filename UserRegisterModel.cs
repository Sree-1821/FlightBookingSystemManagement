using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Web_API.Controllers;
using Web_API.Models;

namespace Web_API.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "*")]
        public int CustomerID { get; set; }



        [Required(ErrorMessage = "*")]
        public string Firstname { get; set; }



        [Required(ErrorMessage = "*")]
        public string Lastname { get; set; }



        [Required(ErrorMessage = "*")]
        public int Age { get; set; }



        [Required(ErrorMessage = "*")]
        public string Gender { get; set; }



        [Required(ErrorMessage = "*")]
        public string EmailID { get; set; }



        [Required(ErrorMessage = "*")]
        public string MobileNumber { get; set; }



        [Required(ErrorMessage = "*")]
        public string Username { get; set; }



        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
    }
}
  
    
