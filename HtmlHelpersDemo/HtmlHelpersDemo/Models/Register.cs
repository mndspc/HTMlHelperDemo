﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpersDemo.Models
{
    public class Register
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string Password { get; set; }

        public string Country { get; set; }

        public bool Terms { get; set; }
    }
}