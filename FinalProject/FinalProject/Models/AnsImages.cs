using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class AnsImages
    {
        public int Id { get; set; }

        public string AdsPhotoUrl { get; set; }

        [NotMapped]
        public IFormFile AdsPhoto { get; set; }

        public int AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
