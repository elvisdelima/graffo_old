using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kimera.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("Kimera") { }
 
        public DbSet<Data> Datas { get; set; }
    }
}