using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassWork13042020_MVC_5_ExamleParty.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="")]
        public string Name { get; set; }

        [Required(ErrorMessage = "")]
        public string Email { get; set; }

        [Required(ErrorMessage = "")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "")]
        public bool? WillAttend { get; set; }
    }
}