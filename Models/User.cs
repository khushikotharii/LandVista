using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength (100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}