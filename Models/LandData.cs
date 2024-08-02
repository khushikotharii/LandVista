using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class LandData
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public double LandSize { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        public int OwnerHistory { get; set; }
    }
}