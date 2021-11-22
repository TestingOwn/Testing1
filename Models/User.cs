using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormApplication.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}