using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class HomeVM
    {
        public ICollection<Announcement> Smartphones { get; set; }
        public ICollection<Mark> Marks { get; set; }
        public ICollection<Announcement> Tabs { get; set; }
        public ICollection<Announcement> Notebooks { get; set; }
        public ICollection<Announcement> Tvs { get; set; }
        public ICollection<Announcement> Smartwatchs { get; set; }

        public ICollection<Announcement> Announcements { get; set; }


    }
}
