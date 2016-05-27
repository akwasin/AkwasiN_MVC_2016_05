using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkwasiN_MVC_2016_05.Models
{
    public class CustomAttributeValidation : ValidationAttribute
    {
        public bool CheckProductNumber(object value)
        {
            if (value == null)
            {
                return false;
            }
            var stringToCheck =
            value.ToString().ToLower();
            return !stringToCheck.StartsWith("p")
                   && stringToCheck[2].ToString() == "-";
        }

        public string FormatErrorMess(string field)
        {
            return field + "The Product Number doesnt follow the correct standard";
        }

    }
}