﻿using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class adsVM
    {
        public Announcement Announcement { get; set; }
        public ICollection<AnsImages> AnsImages { get; set; }

        
    }
}
