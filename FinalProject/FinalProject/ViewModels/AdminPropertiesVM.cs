using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class AdminPropertiesVM
    {
        public IEnumerable<Announcement> Announcements { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }

        public IEnumerable<Model> Models { get; set; }
    }
}
