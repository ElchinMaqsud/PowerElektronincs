using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Username və ya şifrə səhvdir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Username və ya şifrə səhvdir"), DataType(DataType.Password), StringLength(255)]
        public string Password { get; set; }
    }
}
