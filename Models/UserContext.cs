using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SystemKnowledgeWebForms.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("Knowledge11")
        {
        }
        public DbSet<AreaOfKnowledge> AreasOfKnowledge { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
