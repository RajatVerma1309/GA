using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamA_Project.Models
{
    public class SignIn
    {
        [Display(Name = "User Name")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "User Password")]
        [Required]
        [DataType(DataType.Password)]
        public string UserPwd { get; set; }

    }
}