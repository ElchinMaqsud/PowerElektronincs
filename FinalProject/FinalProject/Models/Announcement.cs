using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool IsVip { get; set; }
        public bool IsConfirmed { get; set; }
        public int AnnouncementCount { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime AddDate { get; set; }

        [Required,StringLength(370)]
        public string Info { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public virtual Model Model { get; set; }
        public int ModelId { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<AnsImages> AnsImages { get; set; }

        [NotMapped]
        public ICollection<IFormFile> AnsAllImages { get; set; }
    }
}
