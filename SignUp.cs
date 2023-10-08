using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AB_Task_1.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "Provide Your Name")]
        [RegularExpression("^[a-zA-Z]{4,50}$", ErrorMessage= "Name should be between 4 to 50 characters and no special characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Provide Your User ID")]
        [RegularExpression("^[a-zA-Z0-9\\-_]{4,12}$", ErrorMessage = "User ID should be between 4 to 12 characters and only numbers, characters are allowed.")]
        public string UserId { get; set; }


        public string Password { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }

    }
}