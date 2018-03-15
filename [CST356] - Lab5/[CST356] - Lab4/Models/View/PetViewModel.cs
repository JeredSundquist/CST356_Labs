using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//<---added

namespace _CST356____Lab4.Models.View
{
    public class PetViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pet Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Pet Age")]
        public int Age { get; set; }

        public int UserId { get; set; }
    }
}