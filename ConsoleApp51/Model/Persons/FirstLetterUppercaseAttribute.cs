using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Model.Persons
{
    internal class FirstLetterUppercaseAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string password = value.ToString();
                if (password.Length > 0 && char.IsLower(password[0]))
                {
                    return new ValidationResult("Password must start with an uppercase letter.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
