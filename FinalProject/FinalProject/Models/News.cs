using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required,StringLength(70)]
        public string Title { get; set; }
        public string PhotoUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required,StringLength(370)]
        public string Info { get; set; }
        public DateTime AddDate { get; set; }
    }
}
