using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class Registration
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public string Hobbies { get; set; }

    }
}