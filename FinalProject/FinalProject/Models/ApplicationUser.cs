using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, StringLength(100)]
        public string Firstname { get; set; }
        [StringLength(100)]
        public string Lastname { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }
        public string PhotoUrl { get; set; }

        public int OperatorId { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
