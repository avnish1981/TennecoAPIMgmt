using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TennecoAPIMgmt.Models
{
    public class OracleDBContext:DbContext
    {
        public OracleDBContext()
           : base("OracleConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}