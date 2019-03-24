using PMTool_SaaS.Data.Configurations;
using PMTool_SaaS.Data.CustomConventions;
using PMTool_SaaS.Domain.Entities;
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
        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<History> Histories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new HistoryConfiguration());
            modelBuilder.Conventions.Add(new DateTime2Convention());

            //modelBuilder.Conventions.Add();

        }
        //modelBuilder.Configurations.Add();
        //modelBuilder.Conventions.Add();
    
    }
}
