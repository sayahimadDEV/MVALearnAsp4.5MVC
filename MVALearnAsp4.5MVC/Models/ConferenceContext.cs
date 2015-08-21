using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVALearnAsp4._5MVC.Models
{
    public class ConferenceContext : DbContext
    {

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}