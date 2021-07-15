using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestingMVC.Models
{
    public class Gender
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}