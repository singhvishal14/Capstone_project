using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVC.Models
{
    public class AdminInfo
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}