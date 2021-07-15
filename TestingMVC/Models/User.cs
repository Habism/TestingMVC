using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestingMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Profession { get; set; }

        public byte Age { get; set; }

        public Gender Gender { get; set; }

        [Display(Name = "Gender")]
        public byte GenderId { get; set; }
    }
}