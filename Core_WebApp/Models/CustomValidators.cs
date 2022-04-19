using System;
using System.ComponentModel.DataAnnotations;

namespace Core_WebApp.Models
{
    public class NonNegativeAttribute : ValidationAttribute
    {
        
        /// <summary>
        /// Parameter 'value' will be set by the value entered 
        /// for the property from UI where the current attribute 
        /// is applied
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (Convert.ToInt32(value) < 0)
            { 
                return false;
            }
            return true;
        }
    }
}
