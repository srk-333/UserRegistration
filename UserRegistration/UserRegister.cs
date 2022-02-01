﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegister
    {
        // Static Variable
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{2}";
        //Method to Validate First Name
        public static string ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, firstNamePattern))
                return "true";
            else
                return "false";
        }
        //Method to Validate Last Name
        public static string ValidateLastName(string name)
        {
            if (Regex.IsMatch(name, lastNamePattern))
                return "true";
            else
                return "false";
        }
    }
}