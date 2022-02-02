﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    //class inheriting Base class
    public class UserRegisterException:Exception
    {
        public ExceptionType type;
        //Enumeration
        public enum ExceptionType
        {
            EXCEPTION
        }
        //Exception class Constructor.
        public UserRegisterException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}