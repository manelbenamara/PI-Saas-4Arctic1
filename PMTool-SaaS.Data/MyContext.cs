using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTool_SaaS.Data
{
    public class MyContext: DbContext
    {

        public MyContext() : base("MyConnection")
        {

        }


        // dbset


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add();
            //modelBuilder.Conventions.Add();
        }
    }
}
