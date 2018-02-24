using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _CST356____Lab3.Data.Entities
{
    public class User
    {
        //member fields
        [Display(Name = "First Name")]
        [StringLength(50),Required]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [StringLength(50), Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email must follow the format: example@yourservice.something")]
        [Display(Name = "Email Address")]
        public string EmailAdress { get; set; }
        [Range(1, 100),Required]
        [Display(Name = "Years in School")]
        public int YearsInSchool { get; set; }
        [Range(1, 150), Required]
        [Display(Name = "Age")]
        public int Age { get; set; }
        //non member field: used as primary key to uniquely identify users
        public int Id { get; set; }
    }
}