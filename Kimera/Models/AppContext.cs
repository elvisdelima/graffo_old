using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kimera.Models
{
    public class AppContext : DbContext
    {
        //public AppContext() : base("Kimera") { }
        public AppContext() : base("db71c0682782f34582ace1a35c0013a005") { }
 
        public DbSet<Data> Datas { get; set; }
    }
}