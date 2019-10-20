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
    public class RegisterVM
    {
        [Required, StringLength(100)]
        public string FirstName { get; set; }
        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string UserName { get; set; }
        public int OperatorId { get; set; }
        public virtual Operator Operator { get; set; }
        public int Age { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime Birthdate { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        [Required]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber),Required]
        public string PhoneNumber { get; set; }

        [Required, DataType(DataType.Password), StringLength(255)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
