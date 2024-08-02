using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Prediction
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("LandData")]
        public int LandID { get; set; }

        public LandData LandData { get; set; }

        [Required]
        [StringLength(50)]
        public string PredictionResult { get; set; }

        [Required]
        public double Probability { get; set; }

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}