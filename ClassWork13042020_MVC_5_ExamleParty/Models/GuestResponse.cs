using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassWork13042020_MVC_5_ExamleParty.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please, enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter your email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="You entered an incorrect password")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please, indicate whether you will attend the party")]
        public bool? WillAttend { get; set; }
    }
}