using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Qwonze.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class QwonzeContext : DbContext
    {
        public QwonzeContext()
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QwonzeContext>());
        }

        public virtual DbSet<QBlogPost> Posts { get; set; }
    }
}