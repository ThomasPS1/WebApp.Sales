using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnnotationsExtensions;

namespace WebApp.Entity.ViewModels
{
    public class RegisterViewModel
    {
        [Email]
        public required string UserName {  get; set; }
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password not matching..")]
        public required string  ConfirmPassword { get; set; }

    }
}
