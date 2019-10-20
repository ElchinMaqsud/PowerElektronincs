using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MarkId { get; set; }
        public virtual Mark Mark { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
