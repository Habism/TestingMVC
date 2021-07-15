using TestingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingMVC.ViewModels
{
    public class UserFormViewModel
    {
        public User User { get; set; }

        public IEnumerable<Gender> Gender { get; set; }
    }
}