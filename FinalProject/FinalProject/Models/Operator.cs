using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Operator
    {
        public int Id { get; set; }
        public string OperatorNumber { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
