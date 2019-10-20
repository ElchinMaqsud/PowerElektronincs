using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class UserProfileVM
    {
        public ApplicationUser  LoggedUser { get; set; }
        public ICollection<Announcement> Announcements { get; set; }
    }
}
