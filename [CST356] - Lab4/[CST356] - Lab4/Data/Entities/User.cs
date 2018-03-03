using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//<---added

namespace _CST356____Lab4.Data.Entities
{
    public class User
    {
        [Key]//<---used to uniquely identify this entity
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public int YearsInSchool { get; set; }
        public string FavoriteColor { get; set; }
    }
}