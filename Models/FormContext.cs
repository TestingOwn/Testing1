using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormApplication.Models
{
    public class FormContext :DbContext
    {
        public FormContext():
            base("Name=FormConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Form> Forms { get; set; }
    }
}