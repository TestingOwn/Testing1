using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormApplication.Models
{
    public class Form
    {
        public int FormId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Display(Name="User")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
    }
}