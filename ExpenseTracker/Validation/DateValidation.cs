using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Validation
{
    public class FutureDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var dt = DateTime.Parse(value.ToString());
            return dt.Date <= DateTime.Now.Date;
        }
    }
}
