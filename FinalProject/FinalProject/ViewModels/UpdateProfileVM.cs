using FinalProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class UpdateProfileVM
    {
        [DataType(DataType.Password)]
        public string СurrentPassword { get; set; }

       [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [ DataType(DataType.Password), Compare("NewPassword")]
        public string ConfirmPassword { get; set; }

        public ApplicationUser applicationUser { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        public virtual Operator Operator { get; set; }
        [Required]
        public int OperatorId {get; set;}
    }
}
