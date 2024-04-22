using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Model.Persons
{
    internal abstract class Person
    {
        [MinLength(5, ErrorMessage = "UserNames Lenght must be minimum 5!") ]
        [MaxLength(20,ErrorMessage = "UserNames Lenght must be Maximum 20!")]
        public string UserName { get; set; }
        [MinLength(5, ErrorMessage = "Password Lenght must be minimum 5!")]
        [MaxLength(40, ErrorMessage = "Password Lenght must be Maximum 40!")]
        [FirstLetterUppercase(ErrorMessage = "Password must start with an Uppercase Letter!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "FirstName is required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required!")]
        public string LastName { get; set; }
        [Range(18, int.MaxValue, ErrorMessage = "Age must be 18 or older!")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email address!")]
        public string Mail { get; set; }

        public abstract string DisplayInfo();
    }
}
