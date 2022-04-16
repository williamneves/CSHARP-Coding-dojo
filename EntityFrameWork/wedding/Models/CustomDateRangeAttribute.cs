using System;
using System.ComponentModel.DataAnnotations;

namespace Wedding.Models
{
    public class CustomDateRangeAttribute : RangeAttribute
    {
        public CustomDateRangeAttribute() : base(typeof(DateTime), DateTime.Now.ToString(), DateTime.Now.AddYears(2).ToString()) 
        { } 
    }
}