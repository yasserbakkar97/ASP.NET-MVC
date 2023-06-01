using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationProject.Models
{
    public class Context:DbContext
    {
        public DbSet<Skill> Skills { get; set; }

        public DbSet<Info> Infos { get; set; }

    }
}