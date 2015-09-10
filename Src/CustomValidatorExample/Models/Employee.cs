using CustomValidatorExample.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomValidatorExample.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        [CustomTitleValidator] // Custom validation attribute
        public string JobTitle { get; set; }
    }
}